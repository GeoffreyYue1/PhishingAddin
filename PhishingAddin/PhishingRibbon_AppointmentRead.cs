using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace PhishingAddin
{
    public partial class Phishing_AppointmentRead
    {
         public const string MailTo = "geoffrey@Geoffrey1.onmicrosoft.com";
      

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_Phishing_Click(object sender, RibbonControlEventArgs e)
        {
            Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();
            if (inspector != null && inspector.CurrentItem != null)
            {

              

                var item = inspector.CurrentItem;

                MailItem newMail = Globals.ThisAddIn.Application.CreateItem(OlItemType.olMailItem);
                newMail.To = MailTo;
                string subject = "Report Phishing " + item.Subject;
                newMail.Subject = subject.Length > 100 ? subject.Substring(0, 100) : subject;
                newMail.Attachments.Add(item);
                newMail.Body = "This mail was submited as spam by end user, please analysis";
                newMail.DeleteAfterSubmit = true;
                newMail.Send();

                item.Close(OlInspectorClose.olDiscard);
                item.Delete();

                MessageBox.Show("The mail seems to be a phishing or spam, if you click any link please communicate with your manager or contact IT team", "Report Phishing", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
