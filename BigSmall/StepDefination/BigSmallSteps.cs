using BigSmall.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace BigSmall.StepDefination
{
    [Binding]
    public class BigSmallSteps
    {
        BigSmallObject Obj = new BigSmallObject();

        [Given(@"User is home page")]
        public void GivenUserIsHomePage()
        {
            Obj.Homepage();
        }
        
        [When(@"User click on Coproate")]
        public void WhenUserClickOnCoproate()
        {
            Obj.Click();
        }
        
        [When(@"User Enter fullname")]
        public void WhenUserEnterFullname()
        {
            Obj.Name();
        }
        
        [When(@"User Enter Email-id")]
        public void WhenUserEnterEmail_Id()
        {
            Obj.Email();
        }
        
        [When(@"User Enter PhoneNo")]
        public void WhenUserEnterPhoneNo()
        {
            Obj.Phone();
        }
        
        [When(@"User Fill Enquiry")]
        public void WhenUserFillEnquiry()
        {
            Obj.Enquiry();
        }
        
        [When(@"Click on submit")]
        public void WhenClickOnSubmit()
        {
            Obj.Submit();  
        }
        
        [Then(@"Verify the messeage")]
        public void ThenVerifyTheMesseage()
        {
           // Obj.verifymessage();
        }

    }
}
