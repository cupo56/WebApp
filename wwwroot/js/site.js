document.addEventListener("DOMContentLoaded", function () {
    const input = document.getElementById("globalLiveSearch");
    const items = document.querySelectorAll(".parfum-item");

    if (input) {
        input.addEventListener("input", function () {
            const query = input.value.toLowerCase();

            items.forEach(item => {
                const name = item.getAttribute("data-name");
                const marke = item.getAttribute("data-marke");
                const kopf = item.getAttribute("data-kopfnote");
                const herz = item.getAttribute("data-herznote");
                const basis = item.getAttribute("data-basisnote");

                if (
                    name.includes(query) ||
                    marke.includes(query) ||
                    (kopf?.includes(query) || herz?.includes(query) || basis?.includes(query))
                )
                {
                    item.classList.remove("d-none");
                } else {
                    item.classList.add("d-none");
                }
            });
        });
    }
});
