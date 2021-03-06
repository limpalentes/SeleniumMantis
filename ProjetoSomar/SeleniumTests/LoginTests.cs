﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProjetoSomar.SeleniumPageObjects;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{

  public class LoginTests : WebDriver 
    {



        [Test]
        [Category("CT")]
        public void Login_VerificarLogin()
        {
          
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            HomePageObjects homePageObjects = new HomePageObjects();
            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();
            Assert.Pass();

        }
        [Test]
        [Category("CT")]
        public void Login_VerificarLoginFalha()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            loginPageObjects.WrongLogin();
            Assert.Pass();
        }

        [Test]
        [Category("CT")]
        public void Login_VerificarLostPassword()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            loginPageObjects.WrongLogin();
            Assert.Pass();
        }

        [Test]
        [Category("CT")]
        public void Login_VerificarPerderSenha()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            loginPageObjects.AcessarLostPassword();
            logoutPageObjects.VerificarLostPassword();
            Assert.Pass();
        }

       

    }
}
