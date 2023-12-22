function validate() {
    window.open("file:///D:/site/project/pages/shop.html","_self")
}
function validateblog() {
    window.open("file:///D:/site/project/pages/blog.html","_self")
}
function validatehamkari() {
    window.open("file:///D:/site/project/pages/shop.html","_self")
}
function validateinfo() {
    window.open("file:///D:/site/project/pages/shop.html","_self")
}
function validateshop() {
    window.open("file:///D:/site/project/pages/shop.html","_self")
}
function validateshopwatch() {
    window.open("file:///D:/site/project/pages/shopwatch.html","_self")
}
function validateexit() {
    window.open("file:///D:/site/project/index.html","_self")
}
function login() {
    const username = document.getElementById('username')
    const password = document.getElementById('password')

    if(username.value.trim() === ''){
        username.classList.add('attention')
        return false
    }
    else if(password.value.trim() === ''){
        username.classList.replace('attention','attentiontrue')
        password.classList.add('attention')
        return false
    }
    else if(password.value.trim().length<=5){
        password.classList.add('attention')
        return false
    }
    else{
        return true
    }
}
function register() {
    let formgp = document.getElementsByClassName('formgp')
    console.log(formgp)
    formgp.forEach(e => {
        const forgpspan = e.childNodes[1]
        const forgpinput = e.childNodes[0]
        console.log(forgpspan)
        if(forgpspan.innerText != ""){
            forgpinput.classList.add('attention')
            return false
        }
        else{
            return true
        }
    })
}
function tabs(e,name) {
    var tab_btn = document.getElementsByClassName('tab-btn');
    var tab_content = document.getElementsByClassName('tab-content');
    var i ;
    for (i = 0 ; i < tab_btn.length ; i++) {
        tab_btn[i].classList.remove('active');
    }
    for (i = 0 ; i < tab_content.length ; i++) {
        tab_content[i].style.display = 'none';
    }
    document.getElementById(name).style.display = 'block' ;
    e.currentTarget.classList.add('active');
}
function tabss(e,name) {
    var tab_btn = document.getElementsByClassName('tabbtn');
    var tab_content = document.getElementsByClassName('tab-content');
    var i ;
    for (i = 0 ; i < tab_btn.length ; i++) {
        tab_btn[i].classList.remove('active');
    }
    for (i = 0 ; i < tab_content.length ; i++) {
        tab_content[i].style.display = 'none';
    }
    document.getElementById(name).style.display = 'block' ;
    e.currentTarget.classList.add('active');
}
window.onload = function() {
    const zoom = document.getElementById('zoom')
    const img = document.getElementById('zoom1')
    zoom.addEventListener('mousemove',function(e){
        const x = e.clientX - e.target.offsetLeft;
        const y = e.clientY - e.target.offsetTop;
        img.style.transformOrigin = `${x}px ${y}px`;
        img.style.transform = 'scale(1.5)'
    })
    zoom.addEventListener('mouseleave',function(e){
        img.style.transformOrigin = `center center`;
        img.style.transform = 'scale(1)'
    })
}
document.addEventListener("DOMContentLoaded", (e) => {
    let wallchanger = document.getElementById('wallchanger')
    let wallselect = document.getElementById('zoom1')
    wallchanger.childNodes.forEach(element => {
        element.addEventListener("click",(e)=>{
            wallselect.src = e.target.src
        })
    });
})
