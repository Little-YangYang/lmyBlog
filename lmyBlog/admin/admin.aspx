<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <title>OverView @Blog for LiMuyang -SJQU</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="keywords" content="LiMuyang,LiMuyang Blog,上海建桥学院李沐阳,上海建桥学院李沐阳博客" />
    <meta name="description" content="上海建桥学院李沐阳的博客，李沐阳博客网站，本网站是李沐阳在2018-2019学年度上期ASP.NET课程大作业编写。" />
    <link rel="stylesheet" type="text/css" href="../static/css/admin.css" />
    <link rel="stylesheet" href="../static/css/material.min.css" />
    <script type="text/javascript" src="../static/js/material.min.js"></script>
    <script type="text/javascript" src="../static/js/login.js" charset="gb2312"></script>
    <script type="text/javascript" src="../static/js/jquery-3.2.1.min.js"></script>
    <script type="text/javascript" src="../static/js/wangEditor.min.js"></script>
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Simple header with scrollable tabs. -->
        <div class="mdl-layout mdl-js-layout mdl-layout--fixed-header">
            <header class="mdl-layout__header">
                <div class="mdl-layout__header-row">
                    <!-- Title -->
                    <span class="mdl-layout-title">Blog 后台管理页面</span>
                </div>
                <!-- Tabs -->
                <div class="mdl-layout__tab-bar mdl-js-ripple-effect">
                    <a href="#scroll-tab-1" class="mdl-layout__tab is-active">New Blog</a>
                    <a href="#scroll-tab-2" class="mdl-layout__tab"></a>
                    <a href="#scroll-tab-3" class="mdl-layout__tab">Tab 3</a>
                    <a href="#scroll-tab-4" class="mdl-layout__tab">Tab 4</a>
                    <a href="#scroll-tab-5" class="mdl-layout__tab">Tab 5</a>
                    <a href="#scroll-tab-6" class="mdl-layout__tab">Tab 6</a>
                </div>
            </header>
            <div class="mdl-layout__drawer">
                <span class="mdl-layout-title">Title</span>
            </div>
            <main class="mdl-layout__content">
                <section class="mdl-layout__tab-panel is-active" id="scroll-tab-1">
                    <div class="page-content">
                        <div id="editor">
                        </div>
                    </div>
                </section>
                <section class="mdl-layout__tab-panel" id="scroll-tab-2">
                    <div class="page-content">
                        <!-- Your content goes here -->
                    </div>
                </section>
                <section class="mdl-layout__tab-panel" id="scroll-tab-3">
                    <div class="page-content">
                        <!-- Your content goes here -->
                    </div>
                </section>
                <section class="mdl-layout__tab-panel" id="scroll-tab-4">
                    <div class="page-content">
                        <!-- Your content goes here -->
                    </div>
                </section>
                <section class="mdl-layout__tab-panel" id="scroll-tab-5">
                    <div class="page-content">
                        <!-- Your content goes here -->
                    </div>
                </section>
                <section class="mdl-layout__tab-panel" id="scroll-tab-6">
                    <div class="page-content">
                        <!-- Your content goes here -->
                    </div>
                </section>
            </main>
        </div>
        <script>
            var E = window.wangEditor
            var editor = new E('#editor')
            editor.create()
        </script>
    </form>
</body>
</html>
