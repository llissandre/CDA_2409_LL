$(document).ready(function(){
    let footnotes = $('span[data-footnote]');
    if(footnotes){
        footnotes.each(function(index, element){
            let current = $(element);
            let footnoteText = current.data('footnote');
            current.css('text-decoration', 'underline dashed')
            .after(`<a href="#footnote-${index+1}" id="footnote-anchor-${index+1}"><sup>[${index+1}]</sup></a>`);
        });
    }
});