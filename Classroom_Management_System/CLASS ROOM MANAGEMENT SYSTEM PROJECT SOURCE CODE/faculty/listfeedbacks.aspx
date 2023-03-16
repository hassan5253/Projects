<%@ Page Title="List Of Feedbacks" Trace = "true"  Language="C#" MasterPageFile="~/faculty/FacultyMastePage.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>List Of Feedbacks</h2>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSource1" Width="100%">
            <Columns>
                <asp:BoundField DataField="StudentName" HeaderText="StudentName" 
                    ReadOnly="True" SortExpression="StudentName" />
                <asp:BoundField DataField="BatchId" HeaderText="BatchId" ReadOnly="True" 
                    SortExpression="BatchId" />
                <asp:BoundField DataField="PostedOn" HeaderText="PostedOn" 
                    SortExpression="PostedOn" />
                <asp:BoundField DataField="FeedbackText" HeaderText="FeedbackText" 
                    SortExpression="FeedbackText" />
                <asp:HyperLinkField DataNavigateUrlFields="feedbackid" 
                    DataNavigateUrlFormatString="postreply.aspx?feedbackid={0}" Text="Reply" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetFeedbacks" TypeName="FacultyDAL">
            <SelectParameters>
                <asp:SessionParameter Name="facid" SessionField="facid" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>

</asp:Content>

