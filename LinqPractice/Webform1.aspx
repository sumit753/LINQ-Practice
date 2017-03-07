<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="LinqPractice.Webform1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>
                Using Sql query like expression
            </h3>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        

    </div>
        <div>

            <h3>
                Using lambda Expression
            </h3>
            <asp:gridview ID="GridView2" runat="server"></asp:gridview>
        </div>
    </form>
</body>
</html>
