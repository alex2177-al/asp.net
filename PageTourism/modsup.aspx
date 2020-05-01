<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modsup.aspx.cs" Inherits="PageTourism.modsup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ModSup</title>
</head>
<body>
    <form id="form1" runat="server">

 
        <div style="text-align:center;">
            <asp:GridView AutoGenerateColumns="False"  ID="GridView1" runat="server" DataKeyNames="id" DataSourceID="SqlDataSource1" AllowSorting="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" ItemStyle-Width="100px" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="titre" HeaderText="titre" ItemStyle-Width="100px" SortExpression="titre" />
                    <asp:BoundField DataField="description" HeaderText="description" ItemStyle-Width="200px" SortExpression="description" />
                    <asp:BoundField DataField="prix" HeaderText="prix" ItemStyle-Width="200px" SortExpression="prix" />
                    <asp:BoundField DataField="photo" HeaderText="photo" ItemStyle-Width="200px" SortExpression="photo" />
                    <asp:CheckBoxField DataField="check" HeaderText="check" SortExpression="check" />
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </div>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [voyage] WHERE [id] = @id" InsertCommand="INSERT INTO [voyage] ([titre], [description], [prix], [photo]) VALUES (@titre, @description, @prix, @photo)" SelectCommand="SELECT * FROM [voyage]" UpdateCommand="UPDATE [voyage] SET [titre] = @titre, [description] = @description, [prix] = @prix, [photo] = @photo WHERE [id] = @id">
             <DeleteParameters>
                 <asp:Parameter Name="id" Type="Int32" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="titre" Type="String" />
                 <asp:Parameter Name="description" Type="String" />
                 <asp:Parameter Name="prix" Type="Int32" />
                 <asp:Parameter Name="photo" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="titre" Type="String" />
                 <asp:Parameter Name="description" Type="String" />
                 <asp:Parameter Name="prix" Type="Int32" />
                 <asp:Parameter Name="photo" Type="String" />
                 <asp:Parameter Name="id" Type="Int32" />
             </UpdateParameters>
         </asp:SqlDataSource>
    </form>
</body>
</html>
