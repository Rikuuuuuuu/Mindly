// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Mindly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Mindly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\_Imports.razor"
using Mindly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\Pages\Index.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Koti\Documents\GitHub\Mindly\Mindly\Pages\Index.razor"
              
            string testi = "Testi1";
            string email = "";
            string Id = "Placeholder";
            private string Message { get; set; } = "";
            private void SendMail()
            {
                if (email == "")
                {
                    Message = "Field empty";
                }
                else
                {
                    try
                    {
                        using (MailMessage mail = new MailMessage())
                        {
                            mail.IsBodyHtml = true;
                            mail.From = new MailAddress("mindlytest@gmail.com");
                            mail.To.Add(email);
                            mail.Subject = "Mindly test"; //Aihe
                            Attachment attachment = new System.Net.Mail.Attachment("C:/Users/Koti/Documents/Mindly I cover letter.pdf");//Liite Päivitä oman tiedostosijainnin mukaan
                            mail.IsBodyHtml = true;

                            if (testi == "Testi1")
                            {
                                //Viesti
                                mail.Body = "Congratulations, you have been invited to take the Entrepreneurial Personality Test!<br><br>" +
                                " Please, complete the Entrepreneurial Personality Test according to the instructions below before 20th of November." +
                                " Good luck!<br><br><br>1.Open the link, " + "https://mindly.surveysparrow.com/s/mindly-meps-beta-fin/tt-03d580</a>" + "<br>" +
                                " 2. Add id, " + Id + "<br> 3. Fill the survey <br> 4. Submit <br><br><br> Thank you for your cooperation.";
                                //Liite
                                mail.Attachments.Add(attachment);
                                email = "";
                            }

                            if (testi == "Testi2")
                            {
                                mail.Body = "<h2>Otsikko</h2><p>Testi2</p>";
                                email = "";
                            }

                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                //Email login
                                smtp.Credentials = new System.Net.NetworkCredential("mindlytest@gmail.com", "Koulu1234");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                                Message = "Mail sent";
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }

        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
