Feature: BigSmall
Background: 
Given User is home page
@mytag
Scenario: TO fill Coporate deatils
	Given User is home page
    When  User click on Coproate
	And   User Enter fullname
	And   User Enter Email-id
    And   User Enter PhoneNo
	And   User Fill Enquiry
	And  Click on submit
	Then Verify the messeage




	
