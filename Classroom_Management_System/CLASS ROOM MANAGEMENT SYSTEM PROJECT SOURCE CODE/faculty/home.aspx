<%@ Page Title="Post Topics" Language="C#" MasterPageFile="~/faculty/FacultyMastePage.master" Trace = "true" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<script runat="server">

    protected void btnAddTopics_Click(object sender, EventArgs e)
    {
        // validation
        DateTime date;
        try
        {
            date = DateTime.Parse(txtDate.Text);
            if (date.CompareTo(DateTime.Today) > 0)
            {
                lblMsg.Text = "Sorry! Invalid Date. Must be <= today";
                return;
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = "Sorry! Invalid Date. Must be in MM/DD/YY format";
            return; 
        }
        // call DAL
        bool done = FacultyDAL.AddTopics(ddlBatches.SelectedValue,
             date,txtTopics.Text, txtExercises.Text);
        if (done)
            lblMsg.Text = "Topics added successfully for the date : " + txtDate.Text;
        else
            lblMsg.Text = "Error prevented the topics from getting added!";
        
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<h2>Post Topics</h2>
<table>
<tr>
<td>Select Batch : </td>
<td>
    <asp:DropDownList ID="ddlBatches" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="BatchId" 
        DataValueField="BatchId">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetRunningBatches" TypeName="FacultyDAL">
        <SelectParameters>
            <asp:SessionParameter Name="facid" SessionField="facid" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</td>
</tr>

<tr>
<td>Select Date : </td>
<td>
    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    <cc1:CalendarExtender ID="txtDate_CalendarExtender" runat="server" 
        Enabled="True"  Format = "MM/dd/yy" TargetControlID="txtDate">
    </cc1:CalendarExtender>
</td>
</tr>
<tr>
<td>Topics Covered: </td>
<td>
    <asp:TextBox ID="txtTopics" textmode="MultiLine" Rows="3" Columns = "50" runat="server"></asp:TextBox>
</td>
</tr>

<tr>
<td>Exercises Given : </td>
<td>
    <asp:TextBox ID="txtExercises" textmode="MultiLine" Rows="3" Columns = "50" runat="server"></asp:TextBox>
</td>
</tr>
</table>
<p />
    <asp:Button ID="btnAddTopics" runat="server" Text="Add Topics" 
        onclick="btnAddTopics_Click" />
    <p />
    <asp:Label ID="lblMsg" EnableViewState ="false"  runat="server" Text=""></asp:Label>
</asp:Content>

