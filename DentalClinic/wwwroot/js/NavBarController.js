function NavBarController()
{
    let navBar = document.querySelectorAll('div [class="navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"]');
    let signOut = navBar[0].querySelectorAll('#nav-sign-out');

    
    signOut[0].parentNode.removeChild(signOut[0]);

    //TO DO if login remove Login and Registration elements
    let nodeAWelcomeMsg = document.createElement('A');
    nodeAWelcomeMsg.textContent=`Welcome, Ivan`;
    navBar[0].parentNode.appendChild(nodeAWelcomeMsg);
}

NavBarController();