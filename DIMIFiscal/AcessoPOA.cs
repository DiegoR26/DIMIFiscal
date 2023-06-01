using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;


namespace DIMIFiscal {
    public class AcessoPOA {

        private FirefoxDriver Browser { get; set; }

        private string sitePrefeitura = "https://nfe.portoalegre.rs.gov.br/nfse/pages/security/login.jsf";
        private string siteValidado = "https://nfe.portoalegre.rs.gov.br/nfse/pages/home.jsf";
        private string prefeituraConsulta = "https://nfe.portoalegre.rs.gov.br/nfse/pages/security/consultaNFS-e_prestador.jsf#AncoraResultadosPesquisa";
        private string siteDentroNF = "https://nfe.portoalegre.rs.gov.br/nfse/pages/exibicaoNFS-e.jsf";

        private Client client;

        private string user;
        private string password;
        private string emissor;

        private string dtCompIni;
        private string dtCompFin;
        private string dtEmitIni;
        private string dtEmitFin;

        private string arqXML;
        private string arqPDF;


        public AcessoPOA(Client client, string emissor, string dtCompIni, string dtCompFin, string dtEmitIni, string dtEmitFin, string arqXML, string arqPDF) {

            this.client = client;
            this.user = client.User;
            this.password = client.Password;
            this.emissor = emissor;
            this.dtCompIni = dtCompIni;
            this.dtCompFin = dtCompFin;
            this.dtEmitIni = dtEmitIni;
            this.dtEmitFin = dtEmitFin;
            this.arqXML = arqXML;
            this.arqPDF = arqPDF;
        }

        private string getPath() {
            string mainFolder = client.Name;
            string dataFolder = dtCompIni + " a " + dtCompFin;
            string emitFolder = emissor;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), mainFolder, dataFolder, emitFolder);

            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        private FirefoxDriver GetFireFoxDriver() {
            var options = new FirefoxOptions();
            var profile = new FirefoxProfile();

            profile.SetPreference("browser.download.folderList", 2);
            profile.SetPreference("browser.download.dir", getPath());

            options.SetPreference("browser.download.manager.showWhenStarting", false);
            options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf");
            options.SetPreference("browser.download.manager.showAlertOnComplete", false);
            options.SetPreference("browser.download.manager.useWindow", false);
            profile.SetPreference("browser.download.useDownloadDir", true);
            profile.SetPreference("browser.download.manager.alertOnEXEOpen", false);

            options.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
            options.SetPreference("services.sync.prefs.sync.browser.download.manager.showAlertOnComplete", false);
            options.SetPreference("services.sync.prefs.sync.browser.download.manager.useWindow", false);
            options.SetPreference("services.sync.prefs.sync.browser.download.manager.closeWhenDone", true);

            options.SetPreference("moz:webdriverClick.DEFAULT_LINK_BEHAVIOR", 0);

            options.AddArgument("--headless");

            options.Profile = profile;

            return new FirefoxDriver(options);
        }


        public void validarAcessoPOA() {
            Browser = GetFireFoxDriver();

            Browser.Navigate().GoToUrl(sitePrefeitura);

            Browser.FindElement(By.XPath("//*[@id=\"username\"]")).SendKeys(user);
            Browser.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys(password);
            Browser.FindElement(By.XPath("//*[@id=\"mainContent\"]/div/form/input[5]")).Click();

            WebDriverWait wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));

            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            Browser.Navigate().GoToUrl(siteValidado);

            if (Browser.Url == siteValidado) {

                Browser.Navigate().GoToUrl(prefeituraConsulta);

                Actions actions = new Actions(Browser);
                IWebElement campoData;

                wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
                Thread.Sleep(2000);

                campoData = Browser.FindElement(By.XPath("//*[@id=\"form:dtCompetenciaInicial\"]"));
                actions.MoveToElement(campoData).Click().Build().Perform();
                Thread.Sleep(200);
                actions.SendKeys(dtCompIni).Build().Perform();

                campoData = Browser.FindElement(By.XPath("//*[@id=\"form:dtCompetenciaFinal\"]"));
                actions.MoveToElement(campoData).Click().Build().Perform();
                Thread.Sleep(200);
                actions.SendKeys(dtCompFin).Build().Perform();

                campoData = Browser.FindElement(By.XPath("//*[@id=\"form:dtInicial\"]"));
                actions.MoveToElement(campoData).Click().Build().Perform();
                Thread.Sleep(200);
                actions.SendKeys(dtEmitIni).Build().Perform();

                campoData = Browser.FindElement(By.XPath("//*[@id=\"form:dtFinal\"]"));
                actions.MoveToElement(campoData).Click().Build().Perform();
                Thread.Sleep(200);
                actions.SendKeys(dtEmitFin).Build().Perform();

                if (emissor == "prestados") {
                    Browser.FindElement(By.XPath("//*[@id=\"form:perfil:0\"]")).Click();
                } else if (emissor == "tomados") {
                    Browser.FindElement(By.XPath("//*[@id=\"form:perfil:1\"]")).Click();
                } else {
                    Browser.Quit();
                    MessageBox.Show("Erro ao definir o emissor (prestados ou tomados)");
                }

                Thread.Sleep(2000);

                Browser.FindElement(By.XPath("//*[@id=\"form:bt_procurar_NFS-e\"]")).Click();

                Thread.Sleep(5000);

                string NrNF;

                int NF = 0;
                int PG = 4;

                while (PG < 11) {
                    try {
                        if (arqXML == "XMLSim") {
                            Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":bt_download\"]")).Click();
                        }

                        if (arqPDF == "PDFSim") {
                            NrNF = Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":j_id179\"]")).GetAttribute("innerText").Replace('/', '-'); ;

                            Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":j_id179\"]")).Click();
                            wait.Until(driver => driver.Url.Equals(siteDentroNF));
                            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

                            string fileName = $"NF_{NrNF}.png";
                            string fullPath = Path.Combine(getPath(), fileName);

                            Screenshot screenshot = ((ITakesScreenshot)Browser).GetScreenshot();
                            screenshot.SaveAsFile(fullPath, ScreenshotImageFormat.Png);

                            Browser.Navigate().Back();
                        }

                        if ((NF - 9) % 10 == 0) {
                            Browser.FindElement(By.CssSelector("#form\\:j_id160\\:dtRick_table > tbody > tr > td:nth-child(" + PG + ")")).Click();
                            PG++;
                            Thread.Sleep(5000);                           
                        }

                        NF++;

                    } catch (NoSuchElementException) {
                        break;
                    }

                }

                while (PG == 11) {
                    try {
                        if (arqXML == "XMLSim") {
                            Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":bt_download\"]")).Click();
                        }

                        if (arqPDF == "PDFSim") {
                            NrNF = Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":j_id179\"]")).GetAttribute("innerText").Replace('/', '-'); ;

                            Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":j_id179\"]")).Click();
                            wait.Until(driver => driver.Url.Equals(siteDentroNF));
                            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

                            string fileName = $"NF_{NrNF}.png";
                            string fullPath = Path.Combine(getPath(), fileName);

                            Screenshot screenshot = ((ITakesScreenshot)Browser).GetScreenshot();
                            screenshot.SaveAsFile(fullPath, ScreenshotImageFormat.Png);

                            Browser.Navigate().Back();
                        }

                        if ((NF - 9) % 10 == 0) {
                            Browser.FindElement(By.CssSelector("#form\\:j_id160\\:dtRick_table > tbody > tr > td:nth-child(" + PG + ")")).Click();
                            Thread.Sleep(5000);
                        }

                        NF++;

                    } catch (NoSuchElementException) {
                        PG++;

                        try {
                            Browser.FindElement(By.CssSelector("#form\\:j_id160\\:dtRick_table > tbody > tr > td:nth-child(" + PG + ")")).Click();
                            Thread.Sleep(5000);

                        } catch (NoSuchElementException) {
                            break;
                        }

                        PG++;
                       
                    }
                }

                while (true) {
                    try {
                        if (arqXML == "XMLSim") {
                            Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":bt_download\"]")).Click();
                        }

                        if (arqPDF == "PDFSim") {
                            NrNF = Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":j_id179\"]")).GetAttribute("innerText").Replace('/', '-'); ;

                            Browser.FindElement(By.XPath("//*[@id=\"form:j_id160:listaNotas:" + NF + ":j_id179\"]")).Click();
                            wait.Until(driver => driver.Url.Equals(siteDentroNF));
                            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

                            string fileName = $"NF_{NrNF}.png";
                            string fullPath = Path.Combine(getPath(), fileName);

                            Screenshot screenshot = ((ITakesScreenshot)Browser).GetScreenshot();
                            screenshot.SaveAsFile(fullPath, ScreenshotImageFormat.Png);

                            Browser.Navigate().Back();
                        }

                        if ((NF - 9) % 10 == 0) {
                            Browser.FindElement(By.CssSelector("#form\\:j_id160\\:dtRick_table > tbody > tr > td:nth-child(" + PG + ")")).Click();
                            PG++;
                            Thread.Sleep(5000);
                        }

                        NF++;

                    } catch (NoSuchElementException) {
                        break;
                    }

                    if (NF == 0) {
                        MessageBox.Show("Nenhuma Nota Fiscal baixada para a empresa " + this.client.Name);
                    } else if (NF == 1) {
                        MessageBox.Show(NF + " NF baixada!");
                    } else {
                        MessageBox.Show(NF + " NFs baixadas");
                    }
                }


            } else {
                IWebElement errorMessage = Browser.FindElement(By.XPath("//*[@id=\"mensagem\"]/div"));
                string errorText = errorMessage.Text;
                Browser.Quit();
                MessageBox.Show(errorText, "Mensagem de erro do site");
            }

            Browser.Quit();
        }

    }
}
