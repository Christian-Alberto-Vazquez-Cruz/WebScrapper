using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

class Program() {
    static void Main() {
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("start-maximized");
        IWebDriver driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl("http://www.facebook.com");
        Thread.Sleep(5000);

    }
}