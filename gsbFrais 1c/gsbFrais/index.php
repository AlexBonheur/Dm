<?php
if (session_status() === PHP_SESSION_NONE) { session_start(); }

require_once 'model/class.pdogsb.php';
include 'views/layout/vue_entete.php';


require_once 'doc/fct.inc.php';
// connexion à la base de données
$pdo = PdoGsb::getPdoGsb();
$estConnecte = estConnecte();
// Routeur--------------------------------
if (!isset($_REQUEST['uc'])|| !$estConnecte)
    $uc = 'connexion';
else
    $uc = $_REQUEST['uc'];

//Répartiteur-------------------------------
switch ($uc) {
    case 'connexion':
    {
        include 'controllers/c_connexion.php';
        break;
    }
    case 'etatFrais' :{
        include("controllers/c_etatFrais.php");break;
    }
    case 'cumulefrais' :{
        include("controllers/c_cumulefrais.php");break;
    }
    case 'cumulefraismois' :{
        include("controllers/c_cumulefrais.php");break;
    }
    case 'fraisVisiteur' :{
        include("controllers/c_cumulefrais.php");break;
    }
    case 'cumulefraisvisiteurs' :{
        include("controllers/c_cumulefrais.php");break;
    }
    case 'saisiefrais' :{
        include("controllers/c_cumulefrais.php");break;
    }
}

include 'views/layout/vue_pied.php';
