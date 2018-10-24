<html>
    <head>
        <title>
            Q5
        </title>
    </head>
    
    <body>
        <form id="form1" name="form1" method="post" action="">
            <p>
                <label for="input">Enter Number</label>
                <input type="text" name="input" id="input" />
            </p>
            <p>
                <input type="submit" name="button" id="button" />
            </p>
        </form>
        <?php
        cube();
        ?>
        <br><a href="index.php">Return</a>
    </body>
</html>

<?php

function cube()
{
    if(isset($_POST['input']))
    {
       $number=$_POST['input'];
       echo "$number CUBED = ".$number*$number*$number;
    }
}
?>