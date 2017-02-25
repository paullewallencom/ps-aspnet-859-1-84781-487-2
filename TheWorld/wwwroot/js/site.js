// site.js

(function (/*inputParam*/) {

    //var ele = $("#username");

    //ele.text("Paul Lewallen");

    //var main = $("#main");

    //main.on("mouseenter", function () {
    //    main.style = "background-color: #888;";
    //});

    //main.on("mouseleave", function () {
    //    main.style = "";
    //});

    //var menuItems = $("ul.menu li a");

    //menuItems.on("click", function () {
    //    var me = $(this);
    //    alert(me.text());
    //});

    var $sidebarAndWrapper = $("#sidebar,#wrapper");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
    });

})(/*"hello"*/);