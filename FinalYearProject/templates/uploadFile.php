<html>
    <head>
        <title>FYP OCR</title>
    </head>

    <body>
        <form action="/result" method="POST" enctype="multipart/form-data">

            <label for="img_title">Upload the Number</label> <br><br>

            <input type="file" id="img1" /> <br><br>

            <input type="submit" id="img_submit" value="Submit"/>

            <?php
                $allowedExts = array("jpg", "png");
                $temp = explode(".", $_FILES["file"]["name"]);
                $extension = end($temp);

                if ((($_FILES["file"]["type"] == "image/jpg")
                    || ($_FILES["file"]["type"] == "image/png"))
                    && ($_FILES["file"]["size"] < 2097152) // < 2M
                    && in_array($extension, $allowedExts)) {

                        if (file_exists("upload/" .$_FILES["file"]["name"])) {
                            echo $_FILES["file"]["name"] . "already exists.";
                        } else {
                            move_uploaded_file($_FILES["file"]["tmp_name"], "upload/" . $_FILES["file"]["name"]);
                            echo "File save at: " . "upload/" . $_FILES["file"]["name"];
                        }
                } else {
                    echo "Illegal file format.";
                }
            ?>

        </form>

        <script>
            var img = document.getElementById("img").name;
        </script>
    </body>
</html>