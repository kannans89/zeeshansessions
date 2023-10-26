function MakePaginationAccessible() {
     document.querySelectorAll('ul.pagination').forEach((paginator) => {
        paginator.querySelectorAll('li.page-item').forEach((pageItem) => {
            if (pageItem.classList.contains('active')) {
                const span = pageItem.querySelector('span.page-link');
                if (span) {
                    const pageLink = document.createElement('a');
                    pageLink.setAttribute('href', '#');
                    pageLink.setAttribute('aria-label', `Page ${span.innerHTML}`)
                    pageLink.setAttribute('aria-current', 'true');
                    pageLink.classList.add('page-link');
                    pageLink.innerHTML = span.innerHTML;
                    pageItem.appendChild(pageLink);
                    span.remove();
                }

                return;
            }

            const pageLink = pageItem.querySelector('a.page-link');

            if (!pageLink) return;

            if (pageItem.classList.contains('PagedList-skipToFirst')) {
                pageLink.setAttribute('aria-label', 'First page')
                return;
            }
            if (pageItem.classList.contains('PagedList-skipToPrevious')) {
                pageLink.setAttribute('aria-label', 'Previous page')
                return;
            }
            if (pageItem.classList.contains('PagedList-skipToLast')) {
                pageLink.setAttribute('aria-label', 'Last page')
                return;
            }
            if (pageItem.classList.contains('PagedList-skipToNext')) {
                pageLink.setAttribute('aria-label', 'Next page')
                return;
            }

            pageLink.setAttribute('aria-label', `Page ${pageLink.innerHTML}`)
        });
    });
}

document.addEventListener('DOMContentLoaded', MakePaginationAccessible);
