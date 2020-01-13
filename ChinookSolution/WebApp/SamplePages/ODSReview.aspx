<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ODSReview.aspx.cs" Inherits="WebApp.SamplePages.ODSReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="AlbumList" runat="server" DataSourceID="AlbumListODS" AllowPaging="True" PageSize="5" GridLines="Horizontal" BorderStyle="None" CssClass="table table-striped" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="ID"></asp:TemplateField>
            <asp:TemplateField HeaderText="Title"></asp:TemplateField>
            <asp:TemplateField HeaderText="Artist"></asp:TemplateField>
            <asp:TemplateField HeaderText="Year"></asp:TemplateField>
            <asp:TemplateField HeaderText="Label"></asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            No albums to display at this time.
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource ID="AlbumListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Album_List" TypeName="ChinookSystem.BLL.AlbumController">

    </asp:ObjectDataSource>
</asp:Content>
