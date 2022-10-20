function NavBarController()
{
    //TO DO if login remove Login and Registration elements
    let nodeAWelcomeMsg = document.createElement('A');
    nodeAWelcomeMsg.textContent=`Welcome, Ivan`;
    navBar[0].parentNode.appendChild(nodeAWelcomeMsg);
}

NavBarController();