$(document).ready(() => {
    $.ajax({
        type: "post",
        dataType: 'json',
        url: '/home/GetAllServices',
        success: (servicesData) => {
            console.log(servicesData);

            var $serviceTab = $('.service-tab');
            var $navTabs = $serviceTab.find('.nav-tabs');
            var $tabContent = $serviceTab.find('.tab-content');

            servicesData.forEach((item, index) => {

                var nodeLi = `<li class="${(index == 0 ? 'active' : "")}" role="presentation">
                                <a data-toggle="tab" role="tab" aria-controls="tab-${index}" href="#tab-${index}" aria-expanded="true">
                                    <i><img src="${item.imgSrc}" alt="${item.imgAlt}"></i>${item.title}
                                </a>
                             </li>`;
                $navTabs.append(nodeLi);

                var nodeDiv = `<div id="tab-${index}" class="tab-pane ${ (index == 0 ? 'active' : "")}" role="tabpanel">
                                    <div class="tab-box">
                                        <p>${item.description}</p>
                                    </div>
                               </div>`;
                $tabContent.append(nodeDiv);
            });
        },
        error: () => {

        }
    })
})