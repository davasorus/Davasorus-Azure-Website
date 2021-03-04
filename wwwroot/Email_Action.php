<?php
$to = "davasorus.gaming@gmail.com";
$subject = "My subject";
$txt = "Hello world!";
$headers = "From: webmaster@example.com" . "\r\n" .
"CC: davitts2@gmail.com";

mail($to,$subject,$txt,$headers);
?>