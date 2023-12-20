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
function login() {
    const username = document.getElementById('username')
    const password = document.getElementById('password')
    const userror = document.getElementById('userror')
    const passerror = document.getElementById('passerror')

    if(username.value.trim() === ''){
        username.style.border='3px solid red'
        userror.style.display='block';
        userror.innerText = "یوزرنیم را وارد کنید"
        return false
    }
    else if(password.value.trim() === ''){
        password.style.border='3px solid red'
        passerror.style.display='visible';
        userror.style.display='none';
        username.style.border='1px solid black'
        passerror.innerText = "پسورد را وارد کنید"
        return false
    }
    else if(password.value.trim().length<=5){
        passerror.style.display='visible';
        passerror.innerText = "  پسورد کوتاه است  "
        password.style.border='3px solid red'
        return false
    }
    else{
        return true
    }
}
function register() {
    const username = document.getElementById('username')
    const email = document.getElementById('email')
    const password = document.getElementById('password')
    const pass = document.getElementById('password').value
    const passwordrepeat = document.getElementById('passwordrepeat')
    const passrepeat = document.getElementById('passwordrepeat').value
    const userror = document.getElementById('userror')
    const emailrror = document.getElementById('emailrror')
    const passerror = document.getElementById('passerror')
    const passrepeatrror = document.getElementById('passrepeatrror')

    if(username.value.trim() === ''){
        username.style.border='3px solid red'
        userror.style.display='block';
        userror.innerText = "یوزرنیم را وارد کنید"
        return false
    }
    else if(email.value.trim() === ''){
        email.style.border='3px solid red'
        emailrror.style.display='visible';
        userror.style.display='none';
        username.style.border='1px solid black'
        emailrror.innerText = "ایمیل را وارد کنید"
        return false
    }
    else if(password.value.trim() === ''){
        password.style.border='3px solid red'
        passerror.style.display='visible';
        emailrror.style.display='none';
        email.style.border='1px solid black'
        passerror.innerText = "پسورد را وارد کنید"
        return false
    }
    else if(password.value.trim().length<=5){
        passerror.style.display='visible';
        passerror.innerText = "  پسورد کوتاه است  "
        password.style.border='3px solid red'
        return false
    }
    else if(passwordrepeat.value.trim() === ''){
        passwordrepeat.style.border='3px solid red'
        passrepeatrror.style.display='visible';
        passerror.style.display='none';
        password.style.border='1px solid black'
        passrepeatrror.innerText = "پسورد را وارد کنید"
        return false
    }
    else if(passrepeat != pass){
        console.log("true")
        passrepeatrror.style.display='visible';
        passrepeatrror.innerText = " پسورد یکسان نیست "
        passwordrepeat.style.border='3px solid red'
        return false
    }
    else{
        return true
    }
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
document.addEventListener("DOMContentLoaded",()=>{
    let wallchanger = document.getElementById('wallchanger')
    let wallselect = document.getElementById('zoom1')
    wallchanger.childNodes.forEach(element => {
        element.addEventListener("click",(e)=>{
            wallselect.src = e.target.src
        })
    });
})
