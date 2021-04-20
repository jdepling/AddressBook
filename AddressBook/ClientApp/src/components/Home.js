import React, { useState, useEffect} from 'react';

export function Home() {

    return (<GetAddresses/>);
}


function GetAddresses() {
    const [data, setData] = useState([]);
    // This does not work: It sucessfully fetches but then dies when returning the table
    //const response = await fetch('addressbook');
    //const data = await response.json();

    // This works
    useEffect(() => {
        fetch('addressbook')
            .then(response => {
                if (response.ok) return response.json();
                throw response;
            })
            .then(json => {
                setData(json);
            });
    }, []);

    // This kind of works, but has odd side effects in the ui
    //useEffect(async () => {
    //    var response = await fetch('addressbook');
    //    var info     = await response.json();
    //    setData(info);
    //}, []);


    return (
        <table className='table table-striped' aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Street Address</td>
                    <td>City</td>
                    <td>State</td>
                    <td>Zip Code</td>
                </tr>
            </thead>
            <tbody>
                {data.map(info =>
                    <tr>
                        <td>{info.firstName}</td>
                        <td>{info.lastName}</td>
                        <td>{info.streetAddress}</td>
                        <td>{info.city}</td>
                        <td>{info.state}</td>
                        <td>{info.zipCode}</td>
                        </tr>
                    )}
            </tbody>
        </table>
        );
}
