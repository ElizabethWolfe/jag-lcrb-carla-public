﻿Feature: CateringApplicationLicensingRenewalDenied
    As a logged in business user
    I want to pay the first year licensing fee for an approved Catering Application
    And confirm that autorenewal is set to 'No' to prevent renewal of the licence

#-----------------------
# Expiry = Today
#-----------------------

@e2e @catering @privatecorporation @licencerenewal
Scenario: Deny Catering Licence Renewal Today
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And autorenewal is set to 'No'
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------
# Expiry = Yesterday
#-----------------------

@e2e @catering @privatecorporation @licencerenewal
Scenario: Deny Catering Licence Renewal Yesterday
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And autorenewal is set to 'No'
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------
# Expiry = 45 Days Ago
#-----------------------

@e2e @catering @privatecorporation @licencerenewal
Scenario: Deny Catering Licence Renewal 45 Days Ago
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And autorenewal is set to 'No'
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------------
# Expiry = 60 Days From Today
#-----------------------------

@e2e @catering @privatecorporation @licencerenewal
Scenario: Deny Catering Licence Renewal 60 Days Future
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And autorenewal is set to 'No'
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------------
# Expiry = 30 Days From Today
#-----------------------------

@e2e @catering @privatecorporation @licencerenewal
Scenario: Deny Catering Licence Renewal 30 Days Future
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And autorenewal is set to 'No'
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page