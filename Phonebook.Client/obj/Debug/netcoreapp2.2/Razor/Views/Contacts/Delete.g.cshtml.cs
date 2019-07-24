#pragma checksum "C:\Users\Данил\desktop\Phonebook\Phonebook.Client\Views\Contacts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef01b6eefecca00a52464cd8c867172c3b7ae6bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Delete), @"mvc.1.0.view", @"/Views/Contacts/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/Delete.cshtml", typeof(AspNetCore.Views_Contacts_Delete))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef01b6eefecca00a52464cd8c867172c3b7ae6bf", @"/Views/Contacts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7db4ab9c6ffca5dd66ab610ad7a8cff6475d1e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Данил\desktop\Phonebook\Phonebook.Client\Views\Contacts\Delete.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Delete contact";

#line default
#line hidden
            BeginContext(71, 572, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div>
            <p>Are you sure you wanna delete this contact?</p>
            <p>
                <span>Name:</span>
                <span id=""nameLabel""></span>
            </p>
            <p>
                <span>Phone:</span>
                <span id=""phoneLabel""></span>
            </p>

            <a id=""deleteLink"" href=""/contacts/delete/${contact.id}"">
                <button type=""button"" class=""btn btn-danger"">Delete</button>
            </a>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(661, 89, true);
                WriteLiteral("\r\n    <script>\r\n        // get id of current deleting contact\r\n        const contactId = ");
                EndContext();
                BeginContext(751, 5, false);
#line 29 "C:\Users\Данил\desktop\Phonebook\Phonebook.Client\Views\Contacts\Delete.cshtml"
                     Write(Model);

#line default
#line hidden
                EndContext();
                BeginContext(756, 1407, true);
                WriteLiteral(@";

        // base url
        const url = ""http://localhost:5002/api/contacts/"";

        // get contact with id from url param
        $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },

            type: 'GET',
            url: url + contactId,
            dataType: 'json',

            success: function (data) {
                // fill inputs with contact values
                fillInputs(JSON.stringify(data));
            }
        });

        $(""#deleteLink"").on('click', deleteContact);

        function deleteContact() {
            event.preventDefault();

            // send put request to the api
            $.ajax({
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },

                type: 'DELETE',
                url: url + contactId,
                dataType: 'json',

");
                WriteLiteral(@"                error: function () {
                    window.location.href = '/contacts/list';
                }
            });
        }

        function fillInputs(response) {
            const contactData = JSON.parse(response);


            $(""#nameLabel"").text(contactData.name);
            $(""#phoneLabel"").text(contactData.phone);
        }
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591