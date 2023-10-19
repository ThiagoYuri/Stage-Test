const getData = async (url) => {
    var loading = true;
    var result = [];
    const response = await fetch(url);
    console.log(response)
    if (response.ok) {
        try {
            var data = await response.json();
            if ((data.value).length > 0) {
                result = data.value;
                loading = false;
            }
            else
                loading = false;

        } catch (err) {
            loading = false;
        }
    }
    else
        loading = false;

    return { loading, result }
}

const postData = async (url, data) => {
    console.log(data)
    var result = false;
    await fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        mode: 'cors',
        body: JSON.stringify(data)
    })
        .then(response => {
            if (response.ok) {
                return response.json();
            } else {
                throw new Error(response.json());
            }
        })
        .then(data => {
            console.log('criado com sucesso:', data);
            // Voc� pode fazer algo com a resposta da API aqui
        });
    return result 
}


const deleteData = async (url, id) => {
    var result = false;
    await fetch((url+"/"+id), {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json'
        },
        mode: 'cors'
    })
    .then(response => {
        if (response.ok) {
            result = true;
        } else {
            throw new Error('Erro na exclusão');
        }
    })
    .catch(error => {
        console.error('Erro ao excluir:', error);
        // Lida com o erro, se necessário
    });

    return result;
}


export { getData, postData,deleteData}
