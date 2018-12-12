<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="View.Home" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="js/jquery-3.3.1.min.js" type="text/javascript"></script>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/on.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
    
    <title>面向大学生基于软件工程思维协同开发系统</title>
    <style>
        .form_submit {
            margin-bottom: 1%;
            height: 300px;
            vertical-align: middle;
            background-color: aqua;
        }

        .choose_btn {
            margin-top: 2
        }
    </style>
</head>

    <body class="ms-windows">
    <div class="Goods-home">
        <div class="Goods-content">
            <div class="Goods-content-cell-whiteBlock">
                <div class="Goods-content-cell-whiteBlockcontent">
                    <div class="whiteBlockcontent-Header">
                        <img class="imgLogo" src="src/LOGO1.gif" />
                    </div>
                    <h1 class="whiteBlockcontent-Title">软件开发协同系统</h1>
                    <div class="whiteBlockcontentform">
<!--
	                     <section id="content">
		                        <form action="">			                        <h1>会员登录</h1>
			                        <div>
				                        <input type="text" placeholder="用户名" required="" id="username" />
				                        <input type="password" placeholder="密码" required="" id="password" />
			                        </div>
			                         <div class="">
				                        <span class="help-block u-errormessage" id="js-server-helpinfo">&nbsp;</span>			</div> 
			                        <div>
				                        <input type="submit" value="登录" class="btn btn-primary" id="js-btn-login"/>
				                        <a href="#">忘记密码?</a>
			                        </div>
		                        </form>
	                        </section>
-->
                       <div class="row">
                            <div class="col-md-16" >
                                <div class="form-top">
                                    <div class="form-top-left">
                                        <h3 class="text-center">用户登录</h3>
                                    </div>
                                </div>
                                <div class="form-bottom">
                                    <form role="form" method="post" class="login-form" runat="server">
                                         <div class="form-group">
                                             <div class="input-group">
                                              <span class="input-group-addon"><span class="glyphicon glyphicon glyphicon-user" aria-hidden="true"></span></span>
                                              <input type="text" class="form-control" placeholder="Username" aria-describedby="basic-addon1"/>
                                            </div>                                           
                                        </div>
                                        <div class="form-group">
                                            <div class="input-group">
                                              <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-lock" aria-hidden="true"></span></span>
                                              <input type="text" class="form-control" placeholder="password" aria-describedby="basic-addon2"/>
                                            </div>
                                        </div>
                                        <button type="submit" class="form-control btn btn-success">登录
                                             <span class="glyphicon glyphicon glyphicon-user" aria-hidden="true"></span>
                                        </button>
                                    </form>
                                </div>
                           </div>
                        </div>
                    </div>     
                    
                    
                </div>
            </div>
            <div class="Goods-content-cell-blueBlock">
                <div class="Goods-content-cell-blueBlockcontent">
                    <div class="Goods-content-cell-blueBlockcontent-item">
                        <span class="Icon fa fa-search">
                        </span>解决团队协作的沟通问题。
                    </div>
                    <div class="Goods-content-cell-blueBlockcontent-item">
                        <span class="Icon fa fa-comment-o">
                        </span>体验高效的开发环境。
                    </div>
                    <div class="Goods-content-cell-blueBlockcontent-item">
                        <span class="Icon fa fa-home">
                        </span>从程序员到项目经理的培养。
                    </div>
                </div>
            </div>
        </div>
        <div class="Goods-footer Goods-footer-fixed">
            <ul class="Goods-footer-list">
                <li class="Goods-footer-item">
                    <a class="a-style" href="#" rel="noopener">关于</a>
                </li>
                <li class="Goods-footer-item">
                    <a class="a-style" href="#" rel="noopener">帮助中心</a>
                </li>
                <li class="Goods-footer-item">
                    <a class="a-style" href="#" rel="noopener">广告</a>
                </li>
                <li class="Goods-footer-item">
                    <a class="a-style" href="#" rel="noopener">开发者</a>
                </li>
                <li class="Goods-footer-item Goods-footer-coryright">© 2018 Goods Team </li>
            </ul>
        </div>
    </div>
</body>
</html>
 