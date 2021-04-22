import React from 'react';

export function AddressBookInputForm(props) {

    const submit = async (event) => {
        const data = {
            'FirstName': event.target.fname.value,
            'LastName': event.target.lname.value,
            'StreetAddress': event.target.streetAddress.value,
            'City': event.target.city.value,
            'State': event.target.state.value,
            'Zipcode': event.target.zipCode.value
        }

        event.preventDefault();

        const other_params = {
            headers: { "content-type": "application/json; charset=UTF-8" },
            body: JSON.stringify(data),
            method: "POST",
            mode: "cors"
        };

        var response  = await fetch('addressbook', other_params);
        var newRecord = await response.json();

        // clear out form fields
        document.getElementById("input-form").reset();

        // alert
        alert(`Address record added for: ${newRecord.firstName} ${newRecord.lastName}`);
    }


    return (
        <form id="input-form" onSubmit={submit}>
            <table>
                <tr>
                    <td><label for="fname">First name:</label></td>
                    <td><input type="text" id="fname" name="fname" /></td>
                </tr>

                <tr>
                    <td><label for="lname">Last name:</label></td>
                    <td><input type="text" id="lname" name="lname" /></td>
                </tr>

                <tr>
                    <td><label for="streetAddress">Street Address:</label></td>
                    <td><input type="text" id="streetAddress" name="streetAddress" /></td>
                </tr>

                <tr>
                    <td><label for="city">City:</label></td>
                    <td><input type="text" id="city" name="city" /></td>
                </tr>

                <tr>
                    <td><label for="state">State:</label></td>
                    <td><input type="text" id="state" name="state" /></td>
                </tr>

                <tr>
                    <td><label for="zipCode">Zip Code:</label></td>
                    <td><input type="text" id="zipCode" name="zipCode" /></td>
                </tr>
            </table>

            <input type="submit" value="Submit" />
        </form>
    );
}