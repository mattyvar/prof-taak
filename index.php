<?php include_once("Classes/Load.php"); ?>
<?php include_once("Classes/Session.php"); ?>
<?php include_once("Classes/Rol.php");?>
<html>
<?=Session::start();?>
<?= Load::component("allcomponents");?>
<div class="container1 main">

<h1>hallo, en welkom bij jongeren Kansrijker!! neem gerust een kijkje rond!</h1>
op deze pagina zult u vannales vinden over ozne werkzaamheden, en verschillende informatie over hoe wij te werk gaan.
<img src="images/image1.png">
<br/>
<br/>
"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
<img src="images/image2.png">
<br/>
"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

<?php
$userData = Session::get('user');
?>


</div>



</html>
