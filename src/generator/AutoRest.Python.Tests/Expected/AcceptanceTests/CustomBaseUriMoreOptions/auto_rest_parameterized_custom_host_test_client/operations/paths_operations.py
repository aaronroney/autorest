# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.pipeline import ClientRawResponse

from .. import models


class PathsOperations(object):
    """PathsOperations operations.

    :param client: Client for service requests.
    :param config: Configuration of service client.
    :param serializer: An object model serializer.
    :param deserializer: An object model deserializer.
    """

    def __init__(self, client, config, serializer, deserializer):

        self._client = client
        self._serialize = serializer
        self._deserialize = deserializer

        self.config = config

    def get_empty(
            self, vault, secret, key_name, key_version="v1", custom_headers=None, raw=False, **operation_config):
        """Get a 200 to test a valid base uri.

        :param vault: The vault name, e.g. https://myvault
        :type vault: str
        :param secret: Secret value.
        :type secret: str
        :param key_name: The key name with value 'key1'.
        :type key_name: str
        :param key_version: The key version. Default value 'v1'.
        :type key_version: str
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: None
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        :raises:
         :class:`ErrorException<fixtures.acceptancetestscustombaseurimoreoptions.models.ErrorException>`
        """
        # Construct URL
        url = '/customuri/{subscriptionId}/{keyName}'
        path_format_arguments = {
            'vault': self._serialize.url("vault", vault, 'str', skip_quote=True),
            'secret': self._serialize.url("secret", secret, 'str', skip_quote=True),
            'dnsSuffix': self._serialize.url("self.config.dns_suffix", self.config.dns_suffix, 'str', skip_quote=True),
            'keyName': self._serialize.url("key_name", key_name, 'str'),
            'subscriptionId': self._serialize.url("self.config.subscription_id", self.config.subscription_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}
        if key_version is not None:
            query_parameters['keyVersion'] = self._serialize.query("key_version", key_version, 'str')

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters, **operation_config)

        if response.status_code not in [200]:
            raise models.ErrorException(self._deserialize, response)

        if raw:
            client_raw_response = ClientRawResponse(None, response)
            return client_raw_response
