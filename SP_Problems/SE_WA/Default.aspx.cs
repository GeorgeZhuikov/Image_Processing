using SE_Manager;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE_WA
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        private void Prepare()
        {
            if (!IsPostBack)
                txb.Text = (string)Session["Search_Result_String"];
            if (Session["Search_Result"] != null)
                SetSearchResult();
        }

        private void SetSearchResult()
        {
            updResult.ContentTemplateContainer.Controls.Clear();
            var list = (List<ContentMap>)Session["Search_Result"];
            int index = 1;         
            foreach (var content in list)
            {
                Label label = new Label() { ID = "lblSR" + index, Text = string.Format("{0}. {1}", index++, content.Title) };
                LinkButton link = new LinkButton() { ID = "lbtSR" + index, Text = content.Url };
                link.Click += Link_Click;
                updResult.ContentTemplateContainer.Controls.Add(label);
                updResult.ContentTemplateContainer.Controls.Add(new LiteralControl("<br />"));
                updResult.ContentTemplateContainer.Controls.Add(link);
                updResult.ContentTemplateContainer.Controls.Add(new LiteralControl("<br />"));
                updResult.ContentTemplateContainer.Controls.Add(new LiteralControl("<br />"));
            }
            updResult.Update();
        }

        private void Link_Click(object sender, EventArgs e)
        {
            Response.Redirect(((LinkButton)sender).Text);
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Session["Search_Result_String"] = txb.Text;
            Session["Search_Result"] = Manager.GetSearchResult(txb.Text);
            SetSearchResult();
        }
    }
}