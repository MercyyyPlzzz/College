<html>
    <head>
        <title>
            Q6
        </title>
    </head>
    
    <body>
        <?php
        for($i=1;$i<11;$i++)
        {
            echo (rand(1,19)."  ");
            for ($j=1;$j<11;$j++)
            {
            echo (rand(1,19)."  ");
            }
            echo "<br>";
        }
        ?>
        
        <br><a href="index.php">Return</a>
    </body>
</html>
