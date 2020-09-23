﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I add personnel to the organization structure for a(.*)")]
        public void AddPersonnelToOrgStructure(string bizType)
        {
            if (bizType == " private corporation")
            {
                // find the upload test files in the bdd-tests\upload_files folder
                var environment = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(environment).Parent.FullName;
                string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

                // upload a notice of articles document
                string noticeOfArticles = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "notice_of_articles.pdf");
                NgWebElement uiUploadSignage = ngDriver.FindElement(By.XPath("(//input[@type='file'])[3]"));
                uiUploadSignage.SendKeys(noticeOfArticles);

                // upload a central securities register document
                string centralSecuritiesRegister = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "central_securities_register.pdf");
                NgWebElement uiUploadCentralSecReg = ngDriver.FindElement(By.XPath("(//input[@type='file'])[6]"));
                uiUploadCentralSecReg.SendKeys(centralSecuritiesRegister);

                /********** Leader #0 **********/

                // create the leader data
                string leaderFirstName = "Leader0First";
                string leaderLastName = "Leader0Last";
                string leaderTitle = "CTOLeader0";
                string leaderEmail = "leader0@privatecorp.com";

                // open leader #0 form  
                NgWebElement uiOpenLeaderForm = ngDriver.FindElement(By.CssSelector("[addlabel='Add Leadership'][changetypesuffix='Leadership'] button"));
                uiOpenLeaderForm.Click();

                // enter leader #0 first name
                NgWebElement uiLeaderFirst = ngDriver.FindElement(By.CssSelector("input[formControlName='firstNameNew']"));
                uiLeaderFirst.SendKeys(leaderFirstName);

                // enter leader #0 last name
                NgWebElement uiLeaderLast = ngDriver.FindElement(By.CssSelector("input[formControlName='lastNameNew']"));
                uiLeaderLast.SendKeys(leaderLastName);

                // select leader #0 role
                NgWebElement uiLeaderRole = ngDriver.FindElement(By.CssSelector("[addlabel='Add Leadership'][changetypesuffix='Leadership'] input[formcontrolname='isDirectorNew']"));
                uiLeaderRole.Click();

                // enter leader #0 title
                NgWebElement uiLeaderTitle = ngDriver.FindElement(By.CssSelector("input[formControlName='titleNew']"));
                uiLeaderTitle.SendKeys(leaderTitle);

                // enter leader #0 email
                NgWebElement uiLeaderEmail = ngDriver.FindElement(By.CssSelector("input[formControlName='emailNew']"));
                uiLeaderEmail.SendKeys(leaderEmail);

                // enter leader #0 DOB
                NgWebElement uiOpenLeaderDOB = ngDriver.FindElement(By.CssSelector("input[formControlName='dateofBirthNew']"));
                uiOpenLeaderDOB.Click();

                // select the date
                SharedCalendarDate();

                // click on the Confirm button
                NgWebElement uiConfirmButtonLeader = ngDriver.FindElement(By.CssSelector("[changetypesuffix='Leadership'] .fa-save span"));
                uiConfirmButtonLeader.Click();

                /********** Individual Shareholder #0 **********/

                // create the shareholder data
                string shareholderFirstName = "IndyShareholder0First";
                string shareholderLastName = "IndyShareholder0Last";
                string shareholderVotingShares = "1001";
                string shareholderNonVotingShares = "1002";
                string shareholderEmail = "individualshareholder0@privatecorp.com";

                // open shareholder #0 form
                NgWebElement uiOpenShare = ngDriver.FindElement(By.CssSelector("[changetypesuffix='IndividualShareholder'][addlabel='Add Individual Shareholder'] button"));
                uiOpenShare.Click();

                // enter shareholder #0 first name
                NgWebElement uiShareFirst = ngDriver.FindElement(By.CssSelector("app-associate-list[changetypesuffix='IndividualShareholder'] input[formControlName=\"firstNameNew\"]"));
                uiShareFirst.SendKeys(shareholderFirstName);

                // enter shareholder #0 last name
                NgWebElement uiShareLast = ngDriver.FindElement(By.CssSelector("app-associate-list[changetypesuffix='IndividualShareholder'] input[formControlName='lastNameNew']"));
                uiShareLast.SendKeys(shareholderLastName);

                // enter shareholder #0 number of voting shares
                NgWebElement uiShareVotes = ngDriver.FindElement(By.CssSelector("app-associate-list[changetypesuffix='IndividualShareholder'] input[formControlName='numberofSharesNew']"));
                uiShareVotes.SendKeys(shareholderVotingShares);

                // enter shareholder #0 number of non voting shares
                NgWebElement uiShareNonVotes = ngDriver.FindElement(By.CssSelector("app-associate-list[changetypesuffix='IndividualShareholder'] input[formControlName='numberOfNonVotingSharesNew']"));
                uiShareNonVotes.SendKeys(shareholderNonVotingShares);

                // enter shareholder #0 email
                NgWebElement uiShareEmail = ngDriver.FindElement(By.CssSelector("app-associate-list[changetypesuffix='IndividualShareholder'] input[formControlName='emailNew']"));
                uiShareEmail.SendKeys(shareholderEmail);

                // enter shareholder #0 DOB
                NgWebElement uiCalendarS1 = ngDriver.FindElement(By.CssSelector("app-associate-list[changetypesuffix='IndividualShareholder'] input[formControlName='dateofBirthNew']"));
                uiCalendarS1.Click();

                // select the date
                SharedCalendarDate();

                // click on the Confirm button
                NgWebElement uiConfirmButtonIndyShareholder = ngDriver.FindElement(By.CssSelector("[changetypesuffix='IndividualShareholder'] .fa-save span"));
                uiConfirmButtonIndyShareholder.Click(); 
            }

            if (bizType == " partnership")
            {
                    // create individual partner info
                    string partnerFirstName = "IndividualPartner1First";
                    string partnerLastName = "IndividualPartner1Last";
                    string partnerPercentage = "501";
                    string partnerEmail = "individual1@partner.com";

                    // find the upload test file in the bdd-tests\upload_files folder
                    var environment = Environment.CurrentDirectory;
                    string projectDirectory = Directory.GetParent(environment).Parent.FullName;
                    string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

                    // upload the partnership agreement
                    string partnershipPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "partnership_agreement.pdf");
                    NgWebElement uiUploadPartnershipAgreement = ngDriver.FindElement(By.XPath("(//input[@type='file'])[3]"));
                    uiUploadPartnershipAgreement.SendKeys(partnershipPath);

                    // open partner row
                    NgWebElement uiPartnerRow = ngDriver.FindElement(By.CssSelector("[changetypesuffix='IndividualShareholder'] button"));
                    uiPartnerRow.Click();

                    // enter partner first name
                    NgWebElement uiPartnerFirst = ngDriver.FindElement(By.CssSelector("[formcontrolname='firstNameNew']"));
                    uiPartnerFirst.SendKeys(partnerFirstName);

                    // enter partner last name
                    NgWebElement uiPartnerLast = ngDriver.FindElement(By.CssSelector("[formcontrolname='lastNameNew']"));
                    uiPartnerLast.SendKeys(partnerLastName);

                    // enter partner percentage
                    NgWebElement uiPartnerPercentage = ngDriver.FindElement(By.CssSelector("[formcontrolname='interestPercentageNew']"));
                    uiPartnerPercentage.SendKeys(partnerPercentage);

                    // enter partner email
                    NgWebElement uiPartnerEmail = ngDriver.FindElement(By.CssSelector("[formcontrolname='emailNew']"));
                    uiPartnerEmail.SendKeys(partnerEmail);

                    // enter partner DOB
                    NgWebElement uiOpenPartnerDOB = ngDriver.FindElement(By.CssSelector("[formcontrolname='dateofBirthNew']"));
                    uiOpenPartnerDOB.Click();

                    // select the date
                    SharedCalendarDate();
                }

            if (bizType == " sole proprietorship")
            {
                // open the leader row
                NgWebElement uiOpenLeaderForm = ngDriver.FindElement(By.CssSelector("button.btn.btn-secondary"));
                uiOpenLeaderForm.Click();

                // create the leader info
                string firstName = "Leader1First";
                string lastName = "Leader1Last";
                string email = "leader1@soleproprietor.com";

                // enter the leader first name
                NgWebElement uiFirstName = ngDriver.FindElement(By.CssSelector("[formControlName='firstNameNew']"));
                uiFirstName.SendKeys(firstName);

                // enter the leader last name
                NgWebElement uiLastName = ngDriver.FindElement(By.CssSelector("[formControlName='lastNameNew']"));
                uiLastName.SendKeys(lastName);

                // enter the leader email
                NgWebElement uiEmail = ngDriver.FindElement(By.CssSelector("[formControlName='emailNew']"));
                uiEmail.SendKeys(email);

                // select the leader DOB
                NgWebElement uiOpenLeaderDOB = ngDriver.FindElement(By.CssSelector("[formcontrolname='dateofBirthNew']"));
                uiOpenLeaderDOB.Click();

                // select the date
                SharedCalendarDate();
            }

            if (bizType == " society")
            { 
                // create the director #1 info
                string firstName = "Director1First";
                string lastName = "Director1Last";
                string title = "Director1Title";
                string email = "director1@society.com";
                
                // open the director #1 row 
                NgWebElement uiOpenDirectorForm = ngDriver.FindElement(By.CssSelector("[addlabel='Add Director or Officer'][changetypesuffix='Leadership'] button"));
                uiOpenDirectorForm.Click();
                
                // enter the director #1 first name
                NgWebElement uiFirstName = ngDriver.FindElement(By.CssSelector("[formcontrolname='firstNameNew']"));
                uiFirstName.SendKeys(firstName);

                // enter the director #1 last name
                NgWebElement uiLastName = ngDriver.FindElement(By.CssSelector("[formcontrolname='lastNameNew']"));
                uiLastName.SendKeys(lastName);

                // select the director #1 position
                NgWebElement uiPosition = ngDriver.FindElement(By.CssSelector("[formcontrolname='isDirectorNew']"));
                uiPosition.Click();

                // enter the director #1 title
                NgWebElement uiTitle = ngDriver.FindElement(By.CssSelector("[formcontrolname='titleNew']"));
                uiTitle.SendKeys(title);

                // enter the director #1 email
                NgWebElement uiEmail = ngDriver.FindElement(By.CssSelector("[formcontrolname='emailNew']"));
                uiEmail.SendKeys(email);

                // select the director #1 DOB
                NgWebElement uiOpenDirectorDOB = ngDriver.FindElement(By.CssSelector("[formcontrolname='dateofBirthNew']"));
                uiOpenDirectorDOB.Click();

                // select the date
                SharedCalendarDate();
            }

            if (bizType == " public corporation")
            {
                // create the leader #1 data
                string leaderFirst = "Leader1FirstPubCorp";
                string leaderLast = "Leader1LastPubCorp";
                string leaderTitle = "Leader1TitlePubCorp";
                string leaderEmail = "leader1@publiccorp.com";

                // find the upload test file in the bdd-tests\upload_files folder
                var environment = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(environment).Parent.FullName;
                string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

                // upload NOA form
                string NOAPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
                NgWebElement uiUploadNOA = ngDriver.FindElement(By.XPath("(//input[@type='file'])[3]"));
                uiUploadNOA.SendKeys(NOAPath);

                // open leader #1 form
                NgWebElement uiOpenLeaderForm = ngDriver.FindElement(By.CssSelector("[changetypesuffix='Leadership'] button"));
                uiOpenLeaderForm.Click();

                // enter leader #1 first name
                NgWebElement uiLeaderFirst = ngDriver.FindElement(By.CssSelector("[formcontrolname='firstNameNew']"));
                uiLeaderFirst.SendKeys(leaderFirst);

                // enter leader #1 last name
                NgWebElement uiLeaderLast = ngDriver.FindElement(By.CssSelector("[formcontrolname='lastNameNew']"));
                uiLeaderLast.SendKeys(leaderLast);

                // select leader #1 role
                NgWebElement uiLeaderRole = ngDriver.FindElement(By.CssSelector("[formcontrolname='isDirectorNew']"));
                uiLeaderRole.Click();

                // enter leader #1 title
                NgWebElement uiLeaderTitle = ngDriver.FindElement(By.CssSelector("[formcontrolname='titleNew']"));
                uiLeaderTitle.SendKeys(leaderTitle);

                // enter leader #1 email
                NgWebElement uiLeaderEmail = ngDriver.FindElement(By.CssSelector("[formcontrolname='emailNew']"));
                uiLeaderEmail.SendKeys(leaderEmail);

                // select leader #1 DOB
                NgWebElement uiLeaderDOB = ngDriver.FindElement(By.CssSelector("[formcontrolname='dateofBirthNew']"));
                uiLeaderDOB.Click();

                // select the date
                SharedCalendarDate();
            }
        }


        [And(@"I delete the personnel for a(.*)")]
        public void DeletePersonnelFromOrgStructure(string bizType)
        {
            if (bizType == " private corporation")
            {
                NgWebElement uiDeleteLeader = ngDriver.FindElement(By.CssSelector("[addlabel='Add Leadership'] .fa-trash-alt span"));
                uiDeleteLeader.Click();

                NgWebElement uiDeleteShareholder = ngDriver.FindElement(By.CssSelector("[addlabel='Add Individual Shareholder'] .fa-trash-alt span"));
                uiDeleteShareholder.Click();
            }

            if ((bizType == " partnership") || (bizType == " sole proprietorship") || (bizType == " society") || (bizType == " public corporation"))
            {
                NgWebElement uiDeletePersonnel = ngDriver.FindElement(By.CssSelector(".fa-trash-alt span"));
                uiDeletePartner.Click();
            }
        }


        [And(@"the org structure data is successfully deleted for a(.*)")]
        public void DeletionSuccessful(string bizType)
        {
            if (bizType == " private corporation")
            {
                Assert.True(ngDriver.FindElement(By.XPath("//body[not(contains(.,'Leader0First'))]")).Displayed);

                Assert.True(ngDriver.FindElement(By.XPath("//body[not(contains(.,'IndyShareholder0First'))]")).Displayed);
            }

            if (bizType == " partnership")
            {
                Assert.True(ngDriver.FindElement(By.XPath("//body[not(contains(.,'IndividualPartner1First'))]")).Displayed);
            }

            if (bizType == " sole proprietorship")
            {
                Assert.True(ngDriver.FindElement(By.XPath("//body[not(contains(.,'Leader1First'))]")).Displayed);
            }

            if (bizType == " society")
            {
                Assert.True(ngDriver.FindElement(By.XPath("//body[not(contains(.,'Director1First'))]")).Displayed);
            }

            if (bizType == " public corporation")
            {
                Assert.True(ngDriver.FindElement(By.XPath("//body[not(contains(.,'Leader1FirstPubCorp'))]")).Displayed);
            }
        }
    }
}
