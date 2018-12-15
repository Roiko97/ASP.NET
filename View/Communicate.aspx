<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Communicate.aspx.cs" Inherits="View.Communicate" %>

<!DOCTYPE html>
<html>

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">


    <title> - 项目</title>
    <meta name="keywords" content="">
    <meta name="description" content="">

    <link rel="shortcut icon" href="favicon.ico"> <link href="css/bootstrap.min.css?v=3.3.6" rel="stylesheet">
    <link href="css/font-awesome.css" rel="stylesheet">

    <link href="css/animate.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <script>
        function myFunction() {
            // 声明变量
            var input, filter, ul, li, a, i;
            input = document.getElementById('myInput');
            filter = input.value.toUpperCase();
            ul = document.getElementById("myUL");
            li = ul.getElementsByTagName('li');

            // 循环所有列表，查找匹配项
            for (i = 0; i < li.length; i++) {
                a = li[i].getElementsByTagName("a")[0];
                if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
                    li[i].style.display = "";
                } else {
                    li[i].style.display = "none";
                }
            }
        }
    </script>
    
</head>
    <body class="gray-bg">

    <form id="form1" runat="server">

    <div class="wrapper wrapper-content animated fadeInUp">
        <div class="row">
            <div class="col-sm-12">

                <div class="ibox">
                    <div class="ibox-title">
                        <h5>所有项目</h5>
                        <div class="ibox-tools">
                            <button  type="button" data-toggle="modal" data-target="#myModal" class="btn btn-primary btn-xs">创建新项目</button>
                            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                              <div class="modal-dialog" role="document"  style="z-index:3000!important">
                                <div class="modal-content">
                                  <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                    <h4 class="modal-title" id="myModalLabel">Modal title</h4>
                                  </div>
                                  <div class="modal-body">
                                    ...
                                  </div>
                                  <div class="modal-footer">
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    <button type="button" class="btn btn-primary">Save changes</button>
                                  </div>
                                </div>
                              </div>
                            </div>
                        </div>
                    </div>
                    <div class="ibox-content">
                        <div class="row m-b-sm m-t-sm">
                            <div class="col-md-1">
                                <a href="javascript:location.reload();" class="fa fa-refresh">刷新</a>
                            </div>
                            <div class="col-md-11">
                                <div class="input-group search">
                                    <input type="text" placeholder="请输入项目名称" class="input-sm form-control" id="myInput" onkeyup="myFunction()"/> 
                                    <%--<ul id="myUL">
                                      <li><a href="#" class="header">A</a></li>
                                      <li><a href="#">Adele</a></li>
                                      <li><a href="#">Agnes</a></li>

                                      <li><a href="#" class="header">B</a></li>
                                      <li><a href="#">Billy</a></li>
                                      <li><a href="#">Bob</a></li>

                                      <li><a href="#" class="header">C</a></li>
                                      <li><a href="#">Calvin</a></li>
                                      <li><a href="#">Christina</a></li>
                                      <li><a href="#">Cindy</a></li>
                                    </ul>--%>
                                    <span class="input-group-btn">
                                        <button type="button" class="btn btn-sm btn-primary"> 搜索</button>
                                    </span>
                                </div>
                            </div>
                        </div>

                        <div class="project-list">
                               <%-- <tbody>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">LIKE－一款能够让用户快速获得认同感的兴趣社交应用</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                                &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">米莫说｜MiMO Show</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-default">已取消
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">商家与购物用户的交互试衣应用</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">天狼---智能硬件项目</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">乐活未来</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">【私人医生项目】</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">快狗家居</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-default">已取消
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">线下超市+线上商城+物流配送互联系统</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">P司机汽车省钱专家</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">左左 靠谱男同交友</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="project-status">
                                            <span class="label label-primary">进行中
                                        </td>
                                        <td class="project-title">
                                            <a href="project_detail.html">程序员私活圈</a>
                                            <br/>
                                            <small>创建于 2014.08.15</small>
                                        </td>
                                        <td class="project-completion">
                                            &nbsp;</td>
                                        <td class="project-people">
                                            &nbsp;</td>
                                        <td class="project-actions">
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-folder"></i> 查看 </a>
                                            <a href="projects.html#" class="btn btn-white btn-sm"><i class="fa fa-pencil"></i> 编辑 </a>
                                        </td>
                                    </tr>
                                    </tbody>
                               --%> 
                               <asp:GridView ID="GridView1" runat="server" Width="1043px" AutoGenerateColumns="False" CssClass="project-status">
                                   
                               </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    <!-- 全局js -->
    <script src="js/jquery.min.js?v=2.1.4"></script>
    <script src="js/bootstrap.min.js?v=3.3.6"></script>


    <!-- 自定义js -->
    <script src="js/content.js?v=1.0.0"></script>


    <script>
        $(document).ready(function () {

            $('#loading-example-btn').click(function () {
                btn = $(this);
                simpleLoad(btn, true)

                // Ajax example
                //                $.ajax().always(function () {
                //                    simpleLoad($(this), false)
                //                });

                simpleLoad(btn, false)
            });
        });

        function simpleLoad(btn, state) {
            if (state) {
                btn.children().addClass('fa-spin');
                btn.contents().last().replaceWith(" Loading");
            } else {
                setTimeout(function () {
                    btn.children().removeClass('fa-spin');
                    btn.contents().last().replaceWith(" Refresh");
                }, 2000);
            }
        }
    </script>

    

    </form>

    

    </body>
</html>

