Feature: CRSApplication
    As a logged in business user
    I want to submit a CRS Application

Scenario Outline: Start Application
    Given I am logged in to the dashboard
    And I click on the Start Application button
    And I click on the Continue to Application button
    And I enter <establishment> <street_address> <city> <postal> <pid> <store_email> <store_phone> <contact_given> <contact_surname> <contact_title> <contact_phone> <contact_email>
    And I complete the application
    And I click on the Submit & Pay button
    And I enter the payment information
    Then I return to the dashboard

     Examples:
    | establishment | street_address | city     | postal | pid       | store_email   | store_phone | contact_given | contact_surname | contact_title | contact_phone | contact_email  |
    | Automaticon   | 645            | Victoria | V9A6X5 | 012345678 | test@test.com | 2505555555  | Automated     | Test            | CEO           | 2501111111    | test1@test.com |
    | 1             | 1              | 1        | V9A6X5 | 012345678 | 1@1.c         | 1           | 1             | 1               |               | 1             | 1              |
