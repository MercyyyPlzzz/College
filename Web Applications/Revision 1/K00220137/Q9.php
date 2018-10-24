<html>
    <head>
        <title>
            Q6
        </title>
    </head>
    
    <body>
        <?php
        if(isset($_GET['month']) )
        {
            $month=$_GET['month'];
            if(($month >=1) && ($month <=12) )
            {
                echo $month." is a month";
            }
 else{
     echo "$month is not valid";
 }
        }
        else{
        ?>
        <form id="form1" name="form1" method="get" action="">
            <p>
                <label for="month">Enter Month : </label>
                <input type="text" name="month" id="month" />
            </p>
          
            <p>
                <input type="submit" name="button" id="button" />
            </p>
        </form>
        <?php } ?>
        
        <br><a href="index.php">Return</a>
    </body>
</html>
