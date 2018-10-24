<html>
    <head>
        <title>
            Q4
        </title>
    </head>
    
    <body>
        <?php
        $x=45;
        $y=54;
        function swap(&$x,&$y)
        {
            $temp=0;
            $temp=$x;
            $x=$y;
            $y=$temp;
        }
        
        echo "X : ".$x."<br>Y : ".$y."<br>";
        swap($x,$y);
        echo "<br>";
        echo "X : ".$x."<br>Y : ".$y."<br>";
        ?>
        
        <br><a href="index.php">Return</a>
    </body>
</html>
