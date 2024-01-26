window.changeOnScroll = () => {
    const navbar = document.querySelector('.navbar-user');

    const scrollWatcher = document.createElement('div');

    scrollWatcher.setAttribute('data-scroll-watcher', '');
    navbar.before(scrollWatcher);

    const navObserver = new IntersectionObserver((entries) => {
        navbar.classList.toggle('scrolled', !entries[0].isIntersecting);
    });

    navObserver.observe(scrollWatcher);
};