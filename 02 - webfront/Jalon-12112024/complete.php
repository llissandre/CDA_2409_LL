
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@20..48,100..700,0..1,-50..200&icon_names=download" />
    <link rel="stylesheet" href="/styles/main.css">

    <title>Aienova - Jalon HTML & CSS </title>
</head>
<body>

        <div class="hidden">

                            <?php


                    $exo="exo";


                        $student=$_POST["firstname"]." ".$_POST["surname"];
                        $exo1 = $_POST["exo1"];
                        $exo2 = $_POST["exo2"];
                        $exo3 = $_POST["exo3"];
                        $exo4 = $_POST["exo4"];
                        $exo5 = $_POST["exo5"];
                        $exo6 = "";
                        $exo7 = "";
                        


                        if(isset($_POST["exo6"])){

                        $checkboxValues = $_POST["exo6"];
                        
                        // Loop through the selected values
                        foreach ($checkboxValues as $value) {
                            
                            $exo6 .="|".$value."|";
                        }

                        }


                        if(isset($_POST["exo7"])){

                        $checkboxValues = $_POST["exo7"];
                        
                        // Loop through the selected values
                        foreach ($checkboxValues as $value) {
                            
                            $exo7 .="|".$value."|";
                        }

                        }



                        


                        $answer1 =specialcharConverter("<h1>Question n° 1 : Quel est la différence entre le HTML & le CSS ?</h1>
                            <p><strong>Réponse du stagiaire : </strong><br>".$exo1."</p>");

                        $answer2 =specialcharConverter("<h1>Question n° 2 : A quoi correspond , les balises HEAD, BODY et FOOTER ?</h1>
                            <p><strong>Réponse du stagiaire : </strong><br>".$exo2."</p>");

                        $answer3 =specialcharConverter("<h1>Question n° 3 : Quel est la différence entre les id et class en HTML ?</h1>
                            <p><strong>Réponse du stagiaire : </strong><br>".$exo3."</p>
                            </section>");

                        $answer4 = specialcharConverter("<section>
                            <h1>Question n° 4 : Qu'est ce qu'un parent et un enfant en HTML ?</h1>
                            <p><strong>Réponse du stagiaire : </strong><br>".$exo4."</p>
                            </section>");

                    
                            $answer5 = specialcharConverter("<section>
                            <h1>Question n° 5 : En CSS quel est la différence entre un margin et un padding ?</h1>
                            <p><strong>Réponse du stagiaire : </strong><br>".$exo5."</p>
                            </section>");   

                            $answer6 = specialcharConverter("<section>
                            <h1>Question n° 6 : Parmis les affirmations suivantes les quels sont vrais ? ?</h1>
                            <p><strong>Réponse(s) du stagiaire : </strong><br><ul>".$exo6."</ul></p>
                            </section>");


                            $answer7 = specialcharConverter("<section>
                            <h1>Question n° 7 : Parmis les affirmations suivantes les quels sont fausses ? ?</h1>
                            <p><strong>Réponse(s) du stagiaire : </strong><br><ul>".$exo7."</ul></p>
                            </section>");


                    // Step 2: Save the RTF content to a file
                    $file_path1 = './answers/questions/answer1.rtf';
                    $file_path2 = './answers/questions/answer2.rtf';
                    $file_path3 = './answers/questions/answer3.rtf';
                    $file_path4 = './answers/questions/answer4.rtf';
                    $file_path5 = './answers/questions/answer5.rtf';
                    $file_path6 = './answers/questions/answer6.rtf';
                    $file_path7 = './answers/questions/answer7.rtf';
                    $file_path8 = './answers/info.txt';


                    $info = "Nom du stagiaire : ".$student."  |   DWWM 2409  |  Date et heure d'envoi :".date("d/m/Y h:i:s");


                    file_put_contents($file_path1, strip_tags(html_entity_decode($answer1)));
                    file_put_contents($file_path2, strip_tags(html_entity_decode($answer2)));
                    file_put_contents($file_path3, strip_tags(html_entity_decode($answer3)));
                    file_put_contents($file_path4, strip_tags(html_entity_decode($answer4)));
                    file_put_contents($file_path5, strip_tags(html_entity_decode($answer5)));
                    file_put_contents($file_path6, strip_tags(html_entity_decode($answer6)));
                    file_put_contents($file_path7, strip_tags(html_entity_decode($answer7)));
                    file_put_contents($file_path8, $info);

                    filesender($_FILES['exo8'],"exo8");
                    filesender($_FILES['exo9'],"exo9");
                    filesender($_FILES['exo10'],"exo10");

                    function specialcharConverter($text_content){


                        // Convert content to Windows-1252 encoding
                    $encoded_content = mb_convert_encoding($text_content, "Windows-1252", "UTF-8");

                    // Escape special characters for RTF
                    $rtf_content = "{\\rtf1\\ansi\\deff0
                    {\\fonttbl{\\f0 Arial;}}
                    \\f0\\fs24 ";

                    // Loop through each character to handle special characters
                    for ($i = 0; $i < strlen($encoded_content); $i++) {
                        $char = $encoded_content[$i];
                        $ord = ord($char);

                        // Check if character is a special ANSI character
                        if ($ord > 127) {
                            // Convert special characters to RTF encoding, e.g., é -> \'e9
                            $rtf_content .= sprintf("\\'%02x", $ord);
                        } else {
                            // Add regular ASCII characters directly
                            $rtf_content .= $char;
                        }
                    }

                    // Close the RTF document
                    $rtf_content .= "}";

                    return $rtf_content;


                    }


                    function filesender($thefile,$filename){

                        // Define the directory where you want to save the uploaded files
                    $target_directory = "./answers/practices/";

                    // Ensure the directory exists
                    if (!is_dir($target_directory)) {
                        mkdir($target_directory, 0777, true);
                    }

                    // Check if a file was uploaded
                    if (isset($thefile) && $thefile['error'] === UPLOAD_ERR_OK) {
                        $file_tmp_path = $thefile['tmp_name']; // Temporary file path
                        $file_name = $filename.".zip"; // Original file name
                        $target_file_path = $target_directory . $file_name; // Target file path

                        // Move the file from temporary directory to the target directory
                        if (move_uploaded_file($file_tmp_path, $target_file_path)) {
                            echo "File uploaded successfully to: " . $target_file_path;
                        } else {
                            echo "There was an error moving the file.";
                        }
                    } else {
                        echo "No file was uploaded or there was an error during the upload.";
                    }

                    }


                    ?>


        </div>

<div id="complete" class="organizer central-text">
<img class="logo" src="/media/logo-crm.png" alt="">
<h3>Merci <?php echo $student ?> <br><br>Vos réponses ont bien été enregistrés, veuillez attendre le formateur pour qu'il récupère les données de votre jalon. </h3>

</div>


    <footer></footer>


</body>
</html>