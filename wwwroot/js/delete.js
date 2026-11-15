console.log("Arquivo task.js carregado!");

async function deleteTask(id) {

    console.log("Função deleteTask executada!");
    console.log("ID recebido:", id);

    const response = await fetch(`/Task/DeleteWithJs/${id}`, {
        method: 'DELETE'
    });

    console.log("Status:", response.status);

    if (response.ok) {
        location.reload();
    }
}