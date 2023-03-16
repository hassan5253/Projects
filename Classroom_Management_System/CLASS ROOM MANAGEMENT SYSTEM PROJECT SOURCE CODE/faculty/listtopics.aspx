<%@ Page Title="List Topics" Language="C#" MasterPageFile="~/faculty/FacultyMastePage.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>List Topics</h2>
    <p>
        <asp:GridView ID="GridView1" runat="server"
            AutoGenerateColumns="False" 
            DataKeyNames ="batchid"
            DataSourceID="ObjectDataSource1" Width="100%">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="BatchId" HeaderText="BatchId" 
                    SortExpression="BatchId" />
                <asp:BoundField DataField="Subject" HeaderText="Subject" 
                    SortExpression="Subject" />
                <asp:BoundField DataField="StartDate" HeaderText="StartDate" 
                    SortExpression="StartDate" />
            </Columns>
            <SelectedRowStyle BackColor="#99FFCC" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetRunningBatches" TypeName="FacultyDAL">
            <SelectParameters>
                <asp:SessionParameter Name="facid" SessionField="facid" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
<p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSource2" Width="100%" 
            DataKeyNames="topicid">
            <Columns>
                <asp:BoundField DataField="Day" HeaderText="Day" 
                    SortExpression="Day" DataFormatString="{0:MM/dd/yy}" />
                <asp:BoundField DataField="Topics" HeaderText="Topics" 
                    SortExpression="Topics" />
                <asp:BoundField DataField="Exercises" HeaderText="Exercises" 
                    SortExpression="Exercises" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
            SelectMethod="GetTopics" TypeName="FacultyDAL" 
            DeleteMethod="DeleteTopic">
            <DeleteParameters>
                <asp:Parameter Name="topicid" Type="String" />
            </DeleteParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="batchid" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>

</asp:Content>

