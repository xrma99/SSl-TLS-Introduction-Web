// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.onload = initLinkStyle;

function initLinkStyle() {
    
    if (document.getElementsByClassName("guide")) {
        var arrLink = document.getElementsByClassName("guide");
        for (i = 0; i < arrLink.length; i++) {
            var link = arrLink[i];
            /*link.id = 'normal';*/
            link.onclick = clickNav;
            
        }
    }
}



/**
 * 执行点击事件
 * @param {Object} event 鼠标事件
 */
function clickNav(event) {
    var target = event.currentTarget;

    //擦除上次选择的a的样式
    /*
    if (document.getElementsByClassName("guide")) {
        var arrLink = document.getElementsByClassName("guide");
        for (i = 0; i < arrLink.length; i++) {
            var link = arrLink[i];
            
            if (link.id == 'big-bold') {
                link.id = 'normal';
            }
        }
    }*/

    target.id = 'big-bold';

    return true;//阻止浏览器默认事件
}

