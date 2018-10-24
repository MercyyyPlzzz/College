<html>
    <head>
        <title>
            Q6
        </title>
    </head>
    
    <body>
        <?php
        if(isset($_GET['rate']) && isset($_GET['hours']))
        {
            $rate=$_GET['rate'];
            $hours=$_GET['hours'];
            $gross=$rate*$hours;
            echo "Hourly Rate : (".$rate.") X Hours : (".$hours.") = €$gross";
        }
        else{
        ?>
        <form id="form1" name="form1" method="get" action="">
            <p>
                <label for="rate">Enter hourly rate</label>
                <input type="text" name="rate" id="rate" />
            </p>
            <p>
                <label for="hours">Enter hours</label>
                <input type="text" name="hours" id="hours"/>
            </p>
            <p>
                <input type="submit" name="button" id="button" />
            </p>
        </form>
        <?php } ?>
        
        <br><a href="index.php">Return</a>
    </body>
</html>



