$(document).ready(function () {
    getCategories();
});

function getCategories() {
    $('#categoriesTable tbody').empty();
    $.ajax({
        type: 'GET',
        url: "/Home/GetCategories"
    })
        .done(function (data) {
            for (var i = 0; i < data.Categories.length; i++) {
                $('#categoriesTable tbody').append('<tr><td>' + data.Categories[i].Name + '</td><td><button onclick="getBooksForCategory(' + data.Categories[i].ID + ')" class="fa fa-search"/></td></tr>');
            }
        })
}

function getBooksForCategory(categoryID) {
    $('#documentsTable tbody').empty();
    $.ajax({
        type: 'GET',
        url: "/Home/GetBooksForCategory",
        data: {
            "categoryID": categoryID
        }
    })
        .done(function (data) {
            for (var i = 0; i < data.Books.length; i++) {
                if (data.Role === "") {
                    $('#documentsTable tbody').append('<tr><td>' + data.Books[i].Title + '</td><td><a href="/Home/DownloadBook?id=' + data.Books[i].ID + ')" class="fa fa-search"></a></td></tr>');
                }
                else {
                    $('#documentsTable tbody').append('<tr><td>' + data.Books[i].Title + '</td><td><a href="/Home/DownloadBook?id=' + data.Books[i].ID + ')" class="fa fa-search"></a></td></tr>');
                }
            }
        })
}

