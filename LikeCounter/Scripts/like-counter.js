LikeCounter = function (options) {

    this.registerLike = function() {
        console.log('register-like');
        $.ajax({
            url: '/api/register-like',
            type: 'POST',
            contentType: 'application/x-www-form-urlencoded',
            data: { '': options.pageId },
            cache: 'false'
        });        
    };
};