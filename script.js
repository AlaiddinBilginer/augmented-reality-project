window.addEventListener('scroll', () => {
  document.querySelectorAll('.fade-in').forEach((el) => {
    const rect = el.getBoundingClientRect();
    if (rect.top < window.innerHeight - 100) {
      el.classList.add('opacity-100', 'translate-y-0');
    }
  });
});
