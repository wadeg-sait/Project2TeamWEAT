﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Lab2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
    </br>
     <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
    </br>
     <asp:Label ID="Label3" runat="server" Text="Phone:"></asp:Label>
    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
    </br>
     <asp:Label ID="Label4" runat="server" Text="City:"></asp:Label>
    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
    
</asp:Content>
