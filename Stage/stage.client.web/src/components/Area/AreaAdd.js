import React, { Component } from 'react';
import { postData } from '../FetchData'
import { FormRoot } from '../Fragment/Forms/FormRoot'
import * as yup from 'yup';

const config = [
    {
        id: "nome",
        label: "Nome",
        placeholder: "Enter full name",
        type: "text",
        required: true,
        value: "User name",
        values: [],
    }
]

const AreaAdd = () => {
    const schema = yup.object().shape({
        nome: yup
            .string()
            .required(),
    });

    const SaveArea = async (data) => {
        console.log(data)

        const result = await postData("https://localhost:7271/Area", data)
        console.log(result)
    }


    return (
        <div className='align-center'>
            <h1>Nova Area</h1>
            <FormRoot schema={schema} config={config} event={SaveArea}></FormRoot>
        </div>
    );

}

export default AreaAdd ;
