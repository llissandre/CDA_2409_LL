<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@20..48,100..700,0..1,-50..200&icon_names=download" />
    <link rel="stylesheet" href="/styles/main.css">

    <title>CRM - Jalon HTML & CSS </title>
</head>
<body>

    <div class="grider2">

    <header>

    <div class="padder">

    <img class="logo" src="/media/logo-crm.png" alt="">

        <ul>
            <li id="menu1" class="menu" data-section="1">Question 1</li>
            <li id="menu2"  class="menu" data-section="2">Question 2</li>
            <li id="menu3"  class="menu" data-section="3">Question 3</li>
            <li id="menu4"  class="menu" data-section="4">Question 4</li>
            <li id="menu5"  class="menu" data-section="5">Question 5</li>
            <li id="menu6"  class="menu" data-section="6">Question 6</li>
            <li id="menu7"  class="menu" data-section="7">Question 7</li>
            <li id="menu8"  class="menu" data-section="8">Cas pratique 1</li>
            <li id="menu9"  class="menu" data-section="9">Cas pratique 2</li>
            <li id="menu10"  class="menu" data-section="10">Cas pratique 3</li>

        </ul>

    </div>

    </header>



    <main>


    
    <div class="padder">

    <h1>Jalon : HTML & CSS</h1>

    <form method="POST" action="complete.php" enctype="multipart/form-data">

    <?php  

    for($i=1;$i<=10;$i++){


        include "./parts/exercice".$i.".php";

    }




                ?>
    </form>

    </div>






    </main>


    <footer></footer>

    <script>

            $(".menu").click(function(){

            console.log("menu");

            var section = $(this).closest(".menu").data( "section" );

            var newsection = "#exo"+section;


            $(".exo").addClass("hidden");

            $(newsection).removeClass("hidden");


            });


        </script>

    </div>
        
</body>
</html>