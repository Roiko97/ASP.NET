<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summarize.aspx.cs" Inherits="View.Summarize" %>
<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="renderer" content="webkit">

    <title>软件开发协同系统</title>

    <meta name="keywords" content="">
    <meta name="description" content="">

    <!--[if lt IE 9]>
    <meta http-equiv="refresh" content="0;ie.html" />
    <![endif]-->
    <link rel="shortcut icon" href="favicon.ico">
    <link href="css/bootstrap.min.css?v=3.3.6" rel="stylesheet">
    <link href="css/font-awesome.min.css?v=4.4.0" rel="stylesheet">
    <link href="css/animate.css" rel="stylesheet">
    <link href="css/style.css?v=4.1.0" rel="stylesheet">
</head>

<body class="gray-bg">
    <div class="wrapper wrapper-content">
         &nbsp;<h1 class="text-center">Learn Git and GitHub without any code!</h1>
            <h3 class="text-center">&nbsp;</h3>
            <h2 class="text-center">Using the Hello World guide, you’ll create a repository, start a branch, write comments, and open a pull request.&nbsp;&nbsp;</h2>
            <div class="row J_mainContent" id="content-main">
                <div class="row">
                    <div class="col-sm-6">

                        <button type="button" style="padding-left: 150px;text-align:center" class="btn btn-info center-block" id="cteBtn">创建小组</button>&nbsp;
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <h5>组别</h5>
                    </div>
                    <div>
                        <div class="ibox-content no-padding border-left-right">
                            <img alt="Responsive image" class="img-thumbnail" src="src/a1.jpg">
                        </div>
                        <h2>组员1</h2>
                        <h2>组员2</h2>
                        <button class="no-padding border-left-right">Follow</button>
                        <div class="ibox float-e-margins">
                            <div class="ibox-content" style="border-top: none; background-color: #e4eaec;">
                                <h5>任务完成度</h5>
                                <div class="progress progress-striped active">
                                    <div style="width: 75%" aria-valuemax="100" aria-valuemin="0" aria-valuenow="75" role="progressbar" class="progress-bar">
                                        75%
                                        <span class="sr-only"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                    </div>
                    <div class="col-sm-6">
                        <button type="button" style="padding-left: 100px; text-align: center" class="btn btn-primary center-block" id="ItdBtn">系统介绍</button>&nbsp;
                   <div class="ibox-content">
                       <h2>任务列表</h2>
                       <ul class="todo-list m-t">
                           <li>
                               <input type="checkbox" value="" name="" class="i-checks" />
                               <span class="m-l-xs">开会</span>
                               <small class="label label-primary"><i class="fa fa-clock-o"></i>1小时</small>
                           </li>
                           <li>
                               <input type="checkbox" value="" name="" class="i-checks" checked />
                               <span class="m-l-xs">项目开发</span>
                               <small class="label label-info"><i class="fa fa-clock-o"></i>3小时</small>
                           </li>
                           <li>
                               <input type="checkbox" value="" name="" class="i-checks" />
                               <span class="m-l-xs">修改bug</span>
                               <small class="label label-warning"><i class="fa fa-clock-o"></i>2小时</small>
                           </li>
                       </ul>
                   </div>
                    </div>


                </div>
            </div>
    </div>
    <!-- 全局js -->
    <script src="js/jquery.min.js?v=2.1.4"></script>
    <script src="js/bootstrap.min.js?v=3.3.6"></script>
    <script src="js/plugins/layer/layer.min.js"></script>
    <!-- Flot -->
    <script src="js/plugins/flot/jquery.flot.js"></script>
    <script src="js/plugins/flot/jquery.flot.tooltip.min.js"></script>
    <script src="js/plugins/flot/jquery.flot.resize.js"></script>
    <script src="js/plugins/flot/jquery.flot.pie.js"></script>
    <!-- 自定义js -->
    <script src="js/content.js"></script>
    <!--flotdemo-->
 </body>

</html>
