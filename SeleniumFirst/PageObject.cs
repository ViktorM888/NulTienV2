using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace SeleniumFirst
{
    class PageObject
    {
        public PageObject()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.Id, Using = "et_pb_contact_name_1")]
        public IWebElement TextBoxName { get; set; }


        [FindsBy(How = How.Id, Using = "et_pb_contact_message_1")]
        public IWebElement TextBoxMessage { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@id='et_pb_contact_form_1']//button[@name='et_builder_submit_button'][contains(text(),'Submit')]")]
        public IWebElement ClickSubmitButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input.input.et_pb_contact_captcha")]
        public IWebElement BoxCaptchaNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.et-pb-contact-message > p")]
        public IWebElement MessageSuccess { get; set; }

        [FindsBy(How = How.ClassName, Using = "et_pb_contact_captcha_question")]
        public IWebElement AfterAndBeforeCaptcha { get; set; }



        public void SubmitForm(string textboxname, string textboxmessage, int boxtextnumber)

        {
            TextBoxName.EnterText(textboxname);
            System.Threading.Thread.Sleep(3000);
            TextBoxMessage.EnterText(textboxmessage);
            System.Threading.Thread.Sleep(3000);
            BoxCaptchaNumber.FillResultField(boxtextnumber);
            System.Threading.Thread.Sleep(3000);
            ClickSubmitButton.Click();
            


            



        }
        public String GetSucessErrorMsgText()
        {
            return MessageSuccess.Text;
        }
        public String MessageBox()
        {
            return TextBoxMessage.Text;
        }
        public String BoxNameField()
        {
            return AfterAndBeforeCaptcha.Text;
        }
    }
}
