<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="prozeman.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" dir="ltr">
<head runat="server">
    <title>مدیریت کاربران</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-dark text-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2 class="text-center text-pink">مدیریت کاربران</h2>
            <asp:Label class="text-center text-pink" ID="lblMessage" runat="server"></asp:Label>

            <div class="card bg-secondary p-3 mb-4">
                <h4 class="text-light">افزودن کاربر جدید</h4>
                <div class="form-group">
                    <label>کد کاربر:</label>
                    <asp:TextBox ID="txtKarbarId" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>نام:</label>
                    <asp:TextBox ID="txtNam" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>شماره تلفن:</label>
                    <asp:TextBox ID="txtShomareTelefon" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Button ID="btnAddKarbar" runat="server" CssClass="btn btn-success" Text="افزودن" OnClick="btnAddKarbar_Click" />
            </div>

            <div class="card bg-secondary p-3 mb-4">
                <h4 class="text-light">ویرایش کاربر</h4>
                <div class="form-group">
                    <label>کد کاربر:</label>
                    <asp:TextBox ID="txtUpdateKarbarId" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>نام جدید:</label>
                    <asp:TextBox ID="txtUpdateNam" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>شماره تلفن جدید:</label>
                    <asp:TextBox ID="txtUpdateShomareTelefon" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Button ID="btnUpdateKarbaran" runat="server" CssClass="btn btn-warning" Text="ویرایش" OnClick="btnUpdateKarbaran_Click" />
            </div>

            <div class="card bg-secondary p-3">
                <h4 class="text-light">حذف کاربر</h4>
                <div class="form-group">
                    <label>کد کاربر:</label>
                    <asp:TextBox ID="txtDeleteKarbarId" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Button ID="btnDeleteKarbaran" runat="server" CssClass="btn btn-danger" Text="حذف" OnClick="btnDeleteKarbaran_Click" />
            </div>
            <br />
            <div class="card bg-secondary p-3 mb-4">
                <h4 class="text-light">نمایش کاربران</h4>
                <asp:Button ID="btnGetKarbaran" runat="server" CssClass="btn btn-primary mb-3" Text="نمایش کاربران" OnClick="btnGetKarbaran_Click" />
                <asp:GridView ID="gvKarbaran" runat="server" CssClass="table table-striped table-dark"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
