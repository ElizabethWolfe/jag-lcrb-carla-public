Feature: LGApprovalPicnicArea
    As a logged in business user
    I want to submit a Picnic Area Endorsement Application for review and approval

@e2e @catering @privatecorporation @picnic @lgapproval
Scenario: Local Government Approval for Picnic Area Endorsement
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery in Saanich
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee for a Manufacturer application
    And I request a picnic area endorsement
    And I log in as Saanich local government
    And I approve the picnic application
    And I log in as the manufacturer
    And I review the local government response
    Then the application status is updated on the dashboard