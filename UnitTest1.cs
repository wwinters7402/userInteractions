using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

using OpenQA.Selenium;

namespace userInteractions
{
    public class Tests
    {

        private Actions _actions;
        private FirefoxDriver driver1;
            private WebDriverWait _wait;
        [TestFixture]
        public class Interactions
        {
            private WebDriverWait _wait;

            [Test]
            [Obsolete]
            public void DragandDropTest()
            {
                var driver = new FirefoxDriver();
                var actions = new Actions(driver);
                var wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(6));

                driver.Navigate().GoToUrl("https://www.jqueryui.com/droppable/");
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

                IWebElement sourceElement = driver.FindElement(By.Id("draggable"));
                IWebElement targetElement = driver.FindElement(By.Id("droppable"));
                actions.DragAndDrop(sourceElement, targetElement).Perform();

                Assert.AreEqual("Dropped!", targetElement.Text);

                driver.Close();
            }
            [Test]
            [Obsolete]
            public void ResizingExample()
            {
                var driver = new FirefoxDriver();
                var actions = new Actions(driver);
                var wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(6));
                driver.Navigate().GoToUrl("http://jqueryui.com/resizable");
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
                IWebElement resizeHandle = driver.FindElement(By.XPath("//*[@class='ui-resizable-handle ui-icon ui-icon-gripsmall-diagonal-se']))"));
                actions.ClickAndHold(resizeHandle).MoveByOffset(100, 100).Perform();

                Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='resizable' and @style]")).Displayed);

                driver.Close();


            }





        }
        }
    }

