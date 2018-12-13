<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exchange.aspx.cs" Inherits="View.Exchange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="js/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/on.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <title>修改密码</title>
    <style type="text/css">
        #btn {
            display: none;
        }
    </style>
    <script type="text/javascript">
        window.onload = function () {
            document.getElementById("btn").click();
        }
        $('#btn').click(function () {
            $('#myModal').modal(options)
        });
    </script>
</head>
<body runat="server">
    <div runat="server">
        <button id="btn" type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@mdo">Open modal for @mdo</button>
        <div runat="server" class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" data-backdrop="static">
            <div runat="server" class="modal-dialog" role="document">
                <div runat="server" class="modal-content">
                    <div runat="server" class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="exampleModalLabel">密码太不安全,请修改</h4>
                    </div>
                    <div runat="server" class="modal-body">
                        <form runat="server">
                            <div class="form-group" runat="server">
                                <label for="recipient-name" class="control-label">密码:</label>
                                <input runat="server" type="password" class="form-control" id="recipient_name" />
                            </div>
                            <div runat="server" class="modal-footer">
                                <asp:Button runat="server" type="button" class="btn btn-primary" Text="提交" ID="ecBtn" OnClick="ecBtn_Click"></asp:Button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
