function hideBlock() {
    // Get all the divs with the "admin-block" class
    const divs = document.querySelectorAll('.admin-block');

    // Add a click event listener to each div
    divs.forEach(div => {
        div.addEventListener('click', () => {
            // Get the ID of the clicked div
            const clickedId = div.id;

            // // Loop through all the divs
            divs.forEach(otherDiv => {
                otherDiv.style.display = 'none';
            });

            if (clickedId == "admin-user") {
                document.getElementById("manag-user").style.display = "block";
            } else if (clickedId == "admin-news") {
                document.getElementById("manag-news").style.display = "block";
            } else if (clickedId == "admin-post") {
                document.getElementById("manag-post").style.display = "block";
            } else if (clickedId == "admin-blacklist") {
                document.getElementById("manag-blackList").style.display = "block";
            }
            
        });
    });
}

function showBack() {
    const manag = document.querySelectorAll('.management');
    const block = document.querySelectorAll('.admin-block');

    manag.forEach(otherManag => {
        otherManag.style.display = 'none';
    });
    block.forEach(otherBlock => {
        otherBlock.style.display = 'block';
    });
}

function editData(clickedDiv) {
    var labelTags = clickedDiv.querySelectorAll('label');
    for (i = 0; i < labelTags.length; i++) {
        var input = document.createElement('input');
        input.setAttribute('type', 'text');
        input.setAttribute('name', 'user'+i);
        if (labelTags[i].classList.contains('post-content')) {
            var textarea = document.createElement('textarea');
            textarea.setAttribute('name', 'user'+i);
            textarea.setAttribute('cols', '168');
            textarea.setAttribute('rows', '15');
            textarea.textContent = labelTags[i].textContent.trim();
            labelTags[i].parentNode.replaceChild(textarea, labelTags[i]);
        }
        input.value = labelTags[i].textContent.trim();
        labelTags[i].parentNode.replaceChild(input, labelTags[i]);
    }
}

var labelTags = document.querySelectorAll('.forum-box-item label');
for (i = 0; i < labelTags.length; i++) {
    labelTags[i].addEventListener('mouseover', function() {
        this.classList.add('hover');
    });

    labelTags[i].addEventListener('mouseout', function() {
        this.classList.remove('hover');
    });
}

function addUser() {
    document.getElementById("addUser").style.display = "block";
}

function addBlackList() {
    document.getElementById("addBlackList").style.display = "block";
}