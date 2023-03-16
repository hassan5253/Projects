<%@ Page Title="Post Reply" trace="true" Language="C#" MasterPageFile="~/faculty/FacultyMastePage.master" %>

<script runat="server">

    
    protected void btnPostReply_Click(object sender, EventArgs e)
    {
        bool done= FacultyDAL.UpdateFeedback(Request.QueryString["feedbackid"], txtReply.Text);
        if (done)
            lblMsg.Text = "Posted Reply For Feedback!";
        else
            lblMsg.Text = "Sorry! Could Not Post Reply For Feedback!";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Feedback fb = FacultyDAL.GetFeedback(Request.QueryString["feedbackid"]);
            txtFeedback.Text = fb.FeedbackText;
            txtReply.Text = fb.Reply;
        }
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>Post Reply </h2>    
Feedback
<br />
<asp:TextBox ID="txtFeedback" runat="server" rows="3" Columns = "50" TextMode = "MultiLine" >
</asp:TextBox>
<p />
Reply :
<br />
<asp:TextBox ID="txtReply" runat="server" rows="3" Columns = "50" TextMode = "MultiLine" >
</asp:TextBox>
<p />
    <asp:Button ID="btnPostReply" runat="server" Text="Post Reply" 
        onclick="btnPostReply_Click" />
    <p />
    <asp:Label ID="lblMsg" runat="server" Text="" EnableViewState = "false"></asp:Label>


</asp:Content>

